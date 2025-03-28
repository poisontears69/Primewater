using InventoryManagement;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primewater
{
    public partial class inventory : Form
    {

        private Database db = new Database();

        public inventory()
        {
            InitializeComponent();
            LoadItemCodes();
            LoadInventoryStock();
            LoadJobOrderTypes();

            // Set default date to today
            inventoryDateTimePicker.Value = DateTime.Now;

            // Connect the combobox's selection changed event
            inventoryItemCode.SelectedIndexChanged += InventoryItemCode_SelectedIndexChanged;
        }

        private void LoadItemCodes()
        {
            try
            {
                string query = "SELECT item_code, item_description FROM items WHERE item_type = 'Inventory'";
                DataTable dt = db.ExecuteQuery(query);

                inventoryItemCode.DisplayMember = "item_code";
                inventoryItemCode.ValueMember = "item_description";
                inventoryItemCode.DataSource = dt;
                inventoryItemCode.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading item codes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadJobOrderTypes()
        {
            try
            {
                string query = "SELECT job_order_type, job_order_description FROM job_orders";
                DataTable dt = db.ExecuteQuery(query);

                joTypeComboBox.DisplayMember = "job_order_type";
                joTypeComboBox.ValueMember = "job_description";
                joTypeComboBox.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading item codes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InventoryItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryItemCode.SelectedValue != null)
            {
                inventoryItemCode.Text = inventoryItemCode.SelectedValue.ToString();
            }
        }

        private void LoadInventoryStock()
        {
            try
            {
                string query = "SELECT item_code, item_description, quantity FROM inventory_stock"; // Adjust columns if necessary
                DataTable dt = db.ExecuteQuery(query);

                dataGridViewStock.DataSource = dt;
                dataGridViewStock.AutoGenerateColumns = true;
                dataGridViewStock.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Inventory stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(grNumberTextBox.Text))
                {
                    MessageBox.Show("Please enter a GR Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (inventoryItemCode.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an item code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(quantityTextBox.Text, out decimal quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected item code and description
                string itemCode = inventoryItemCode.Text;
                string itemDescription = itemDescriptionTextBox.Text;

                // Begin database transaction
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Insert into capex_receivings
                            string insertReceivingQuery = @"INSERT INTO inventory_receivings 
                        (date_received, gr_number, item_code, item_description, quantity_added) 
                        VALUES 
                        (@date, @gr, @itemCode, @itemDesc, @quantity)";

                            MySqlCommand cmdReceiving = new MySqlCommand(insertReceivingQuery, conn, transaction);
                            cmdReceiving.Parameters.AddWithValue("@date", inventoryDateTimePicker.Value.Date);
                            cmdReceiving.Parameters.AddWithValue("@gr", grNumberTextBox.Text);
                            cmdReceiving.Parameters.AddWithValue("@itemCode", itemCode);
                            cmdReceiving.Parameters.AddWithValue("@itemDesc", itemDescription);
                            cmdReceiving.Parameters.AddWithValue("@quantity", quantity);
                            cmdReceiving.ExecuteNonQuery();

                            // Check if item exists in capex_stock
                            string checkStockQuery = "SELECT quantity FROM inventory_stock WHERE item_code = @itemCode";
                            MySqlCommand cmdCheckStock = new MySqlCommand(checkStockQuery, conn, transaction);
                            cmdCheckStock.Parameters.AddWithValue("@itemCode", itemCode);
                            object existingQuantity = cmdCheckStock.ExecuteScalar();

                            if (existingQuantity != null)
                            {
                                // Item exists, update quantity
                                string updateStockQuery = "UPDATE inventory_stock SET quantity = quantity + @quantity WHERE item_code = @itemCode";
                                MySqlCommand cmdUpdateStock = new MySqlCommand(updateStockQuery, conn, transaction);
                                cmdUpdateStock.Parameters.AddWithValue("@quantity", quantity);
                                cmdUpdateStock.Parameters.AddWithValue("@itemCode", itemCode);
                                cmdUpdateStock.ExecuteNonQuery();
                            }
                            else
                            {
                                // Item does not exist, insert new record
                                string insertStockQuery = "INSERT INTO inventory_stock (item_code, item_description, quantity) VALUES (@itemCode, @itemDesc, @quantity)";
                                MySqlCommand cmdInsertStock = new MySqlCommand(insertStockQuery, conn, transaction);
                                cmdInsertStock.Parameters.AddWithValue("@itemCode", itemCode);
                                cmdInsertStock.Parameters.AddWithValue("@itemDesc", itemDescription);
                                cmdInsertStock.Parameters.AddWithValue("@quantity", quantity);
                                cmdInsertStock.ExecuteNonQuery();
                            }

                            // ✅ Save to `history_log`
                            string historyQuery = @"INSERT INTO history_log (action_type, action_detail, action_date) 
                                            VALUES (@actionType, @actionDetail, NOW())";

                            using (MySqlCommand cmdLogHistory = new MySqlCommand(historyQuery, conn, transaction))
                            {
                                cmdLogHistory.Parameters.AddWithValue("@actionType", "Inventory Receiving");
                                cmdLogHistory.Parameters.AddWithValue("@actionDetail",
                                    $"Received {quantity} of {itemDescription} (Item Code: {itemCode}) under GR Number {grNumberTextBox.Text}");

                                cmdLogHistory.ExecuteNonQuery();
                            }

                            // Commit transaction
                            transaction.Commit();

                            MessageBox.Show("Receiving record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the form
                            LoadInventoryStock();
                            clearReceiving();
                        }
                        catch (Exception ex)
                        {
                            // Rollback transaction on error
                            transaction.Rollback();
                            MessageBox.Show("Error saving receiving record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearReceiving()
        {
            inventoryDateTimePicker.Value = DateTime.Now;
            grNumberTextBox.Clear();
            inventoryItemCode.SelectedIndex = -1;
            itemDescriptionTextBox.Clear();
            quantityTextBox.Clear();

            // Set focus to the first field
            grNumberTextBox.Focus();
        }

        private void clearBtnReceiving_Click(object sender, EventArgs e)
        {
            clearReceiving();
        }

        private void issuanceBtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate main form inputs
                if (string.IsNullOrWhiteSpace(giNumber.Text) ||
                    string.IsNullOrWhiteSpace(joNumber.Text) ||
                    string.IsNullOrWhiteSpace(joTypeComboBox.Text) ||
                    string.IsNullOrWhiteSpace(meterNumber.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate DataGridView items
                if (dataGridViewIssuance.Rows.Count == 0)
                {
                    MessageBox.Show("Please add at least one item to issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Insert into inventory_issues table
                            string insertIssueQuery = @"INSERT INTO inventory_issues 
                        (date_issued, gi_number, jo_number, jo_type, meter_number, remarks) 
                        VALUES (@dateIssued, @giNumber, @joNumber, @meterNumber, @remarks);
                        SELECT LAST_INSERT_ID();";

                            MySqlCommand cmdInsertIssue = new MySqlCommand(insertIssueQuery, conn, transaction);
                            cmdInsertIssue.Parameters.AddWithValue("@dateIssued", IssuanceDateTimePicker.Value.Date);
                            cmdInsertIssue.Parameters.AddWithValue("@giNumber", giNumber.Text);
                            cmdInsertIssue.Parameters.AddWithValue("@joNumber", joNumber.Text);
                            cmdInsertIssue.Parameters.AddWithValue("@meterNumber", meterNumber.Text);
                            cmdInsertIssue.Parameters.AddWithValue("@remarks", remarksTextBox.Text);

                            int issueId = Convert.ToInt32(cmdInsertIssue.ExecuteScalar());

                            // Insert each item from DataGridView into inventory_issue_items and update stock
                            foreach (DataGridViewRow row in dataGridViewIssuance.Rows)
                            {
                                if (row.IsNewRow) continue;

                                string itemCode = row.Cells["item_code"].Value?.ToString();
                                string itemDescription = row.Cells["item_description"].Value?.ToString();
                                int quantityIssued = Convert.ToInt32(row.Cells["quantity"].Value);

                                if (string.IsNullOrWhiteSpace(itemCode) || quantityIssued <= 0)
                                {
                                    MessageBox.Show("Invalid item data. Ensure all rows have valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // Insert into inventory_issue_items
                                string insertItemQuery = @"INSERT INTO inventory_issue_items 
                            (issue_id, item_code, item_description, quantity_issued) 
                            VALUES (@issueId, @itemCode, @itemDescription, @quantityIssued)";

                                MySqlCommand cmdInsertItem = new MySqlCommand(insertItemQuery, conn, transaction);
                                cmdInsertItem.Parameters.AddWithValue("@issueId", issueId);
                                cmdInsertItem.Parameters.AddWithValue("@itemCode", itemCode);
                                cmdInsertItem.Parameters.AddWithValue("@itemDescription", itemDescription);
                                cmdInsertItem.Parameters.AddWithValue("@quantityIssued", quantityIssued);
                                cmdInsertItem.ExecuteNonQuery();

                                // Subtract issued quantity from capex_stock
                                string updateStockQuery = @"UPDATE inventory_stock 
                            SET quantity = quantity - @quantityIssued 
                            WHERE item_code = @itemCode AND quantity >= @quantityIssued";

                                MySqlCommand cmdUpdateStock = new MySqlCommand(updateStockQuery, conn, transaction);
                                cmdUpdateStock.Parameters.AddWithValue("@quantityIssued", quantityIssued);
                                cmdUpdateStock.Parameters.AddWithValue("@itemCode", itemCode);

                                int rowsAffected = cmdUpdateStock.ExecuteNonQuery();
                                if (rowsAffected == 0)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show($"Not enough stock for item {itemCode}. Transaction canceled.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            // Commit transaction if all queries succeed
                            transaction.Commit();
                            MessageBox.Show("Issuance record saved successfully and stock updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Save to History Table
                            string historyQuery = @"INSERT INTO history_log (action_type, action_detail) 
                                            VALUES (@actionType, @actionDetail)";

                            using (MySqlCommand cmdLogHistory = new MySqlCommand(historyQuery, conn))
                            {
                                cmdLogHistory.Parameters.AddWithValue("@actionType", "Inventory Issuance");
                                cmdLogHistory.Parameters.AddWithValue("@actionDetail",
                                    $"Issued items under issue_id {issueId} - GI Number: {giNumber.Text}, JO Number: {joNumber.Text}, Meter Number: {meterNumber.Text}");

                                cmdLogHistory.ExecuteNonQuery();
                            }

                            // Clear form and DataGridView
                            LoadInventoryStock();
                            ClearForm();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error saving issuance record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            IssuanceDateTimePicker.Value = DateTime.Now;
            giNumber.Clear();
            joNumber.Clear();
            joTypeComboBox.SelectedIndex = -1;
            meterNumber.Clear();
            remarksTextBox.Clear();
            dataGridViewIssuance.Rows.Clear(); // Clear DataGridView rows
        }

        private void issuanceBtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = searchTextBox.Text.Trim();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    MessageBox.Show("Please enter a search term.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Modified query to search for partial matches in item_code or item_description
                string query = @"
            SELECT item_code, item_description, quantity 
            FROM inventory_stock 
            WHERE item_code LIKE @searchTerm 
            OR item_description LIKE @searchTerm";

                MySqlParameter[] parameters =
                {
            new MySqlParameter("@searchTerm", "%" + searchTerm + "%")
        };

                DataTable dt = db.ExecuteQuery(query, parameters);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No matching items found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dataGridViewStock.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching Inventory stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetStock_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            LoadInventoryStock();
        }

        private void contextMenuStripIssuance_Opening(object sender, CancelEventArgs e)
        {
            // Check if DataGridView is empty
            bool hasRows = dataGridViewIssuance.Rows.Count > 0;

            // Enable/Disable Remove and Modify options
            removeToolStripMenuItem.Enabled = hasRows;
            modifyToolStripMenuItem.Enabled = hasRows;
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ensure DataGridView has columns before adding rows
            if (dataGridViewIssuance.Columns.Count == 0)
            {
                dataGridViewIssuance.Columns.Add("item_code", "Item Code");
                dataGridViewIssuance.Columns.Add("item_description", "Item Description");
                dataGridViewIssuance.Columns.Add("quantity", "Quantity");
            }

            // Create the form for item selection
            Form addItemForm = new Form();
            addItemForm.Text = "Add Item";
            addItemForm.Size = new Size(400, 250);
            addItemForm.StartPosition = FormStartPosition.CenterParent;

            // Create labels
            Label itemLabel = new Label() { Text = "Item:", Left = 20, Top = 20, AutoSize = true };
            Label descriptionLabel = new Label() { Text = "Description:", Left = 20, Top = 60, AutoSize = true };
            Label quantityLabel = new Label() { Text = "Quantity:", Left = 20, Top = 100, AutoSize = true };

            // Create dropdown for items
            ComboBox itemComboBox = new ComboBox() { Left = 100, Top = 20, Width = 250 };

            // Fetch item_code and item_description from capex_stock
            string query = "SELECT item_code, item_description FROM inventory_stock";
            DataTable dt = db.ExecuteQuery(query);

            itemComboBox.DisplayMember = "item_code"; // Display item_code in dropdown
            itemComboBox.ValueMember = "item_description"; // Store item_description as Value
            itemComboBox.DataSource = dt;


            // Create textbox for item description (readonly)
            TextBox itemDescriptionTextBox = new TextBox() { Left = 100, Top = 60, Width = 250, ReadOnly = true };

            // Create textbox for quantity
            TextBox quantityTextBox = new TextBox() { Left = 100, Top = 100, Width = 250 };

            // Event to update item description when item is selected
            itemComboBox.SelectedIndexChanged += (s, args) =>
            {
                if (itemComboBox.SelectedValue != null)
                {
                    itemDescriptionTextBox.Text = itemComboBox.SelectedValue.ToString();
                }
            };

            // Create OK button
            Button okButton = new Button() { Text = "OK", Left = 150, Top = 150, Width = 100 };
            okButton.Click += (s, args) =>
            {
                if (itemComboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(quantityTextBox.Text))
                {
                    MessageBox.Show("Please select an item and enter a quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Invalid quantity. Enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add to DataGridView
                dataGridViewIssuance.Rows.Add(itemComboBox.Text, itemDescriptionTextBox.Text, quantity);
                addItemForm.Close();
            };

            // Add controls to the form
            addItemForm.Controls.Add(itemLabel);
            addItemForm.Controls.Add(itemComboBox);
            addItemForm.Controls.Add(descriptionLabel);
            addItemForm.Controls.Add(itemDescriptionTextBox);
            addItemForm.Controls.Add(quantityLabel);
            addItemForm.Controls.Add(quantityTextBox);
            addItemForm.Controls.Add(okButton);

            // Show as dialog
            addItemForm.ShowDialog();
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewIssuance.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to modify.", "Modify Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dataGridViewIssuance.SelectedRows[0];

                string currentItemCode = selectedRow.Cells["item_code"].Value?.ToString() ?? "";
                string currentItemDescription = selectedRow.Cells["item_description"].Value?.ToString() ?? "";
                string currentQuantity = selectedRow.Cells["quantity"].Value?.ToString() ?? "";

                // Create the modification form
                Form modifyForm = new Form
                {
                    Text = "Modify Item",
                    Size = new Size(350, 250),
                    StartPosition = FormStartPosition.CenterParent
                };

                // Create dropdown for items
                ComboBox itemComboBox = new ComboBox { Left = 20, Top = 20, Width = 200 };

                try
                {
                    // Fetch item_code and item_description from inventory_stock
                    string query = "SELECT item_code, item_description FROM inventory_stock";
                    DataTable dt = db.ExecuteQuery(query);

                    itemComboBox.DisplayMember = "item_code"; // Display item_code in dropdown
                    itemComboBox.ValueMember = "item_description"; // Store item_description as Value
                    itemComboBox.DataSource = dt;
                    itemComboBox.Text = currentItemCode;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading item list: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create textbox for item description (readonly)
                TextBox itemDescriptionTextBox = new TextBox
                {
                    Left = 20,
                    Top = 60,
                    Width = 300,
                    ReadOnly = true,
                    Text = currentItemDescription
                };

                // Create textbox for quantity
                TextBox quantityTextBox = new TextBox
                {
                    Left = 20,
                    Top = 100,
                    Width = 200,
                    Text = currentQuantity
                };

                // Event to update item description when item is selected
                itemComboBox.SelectedIndexChanged += (s, args) =>
                {
                    try
                    {
                        if (itemComboBox.SelectedValue != null)
                        {
                            itemDescriptionTextBox.Text = itemComboBox.SelectedValue.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating item description: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                // Create OK button
                Button okButton = new Button { Text = "OK", Left = 100, Top = 140, Width = 100 };
                okButton.Click += (s, args) =>
                {
                    try
                    {
                        if (itemComboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(quantityTextBox.Text))
                        {
                            MessageBox.Show("Please select an item and enter a quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
                        {
                            MessageBox.Show("Invalid quantity. Enter a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Update selected row
                        selectedRow.Cells["item_code"].Value = itemComboBox.Text;
                        selectedRow.Cells["item_description"].Value = itemDescriptionTextBox.Text;
                        selectedRow.Cells["quantity"].Value = quantity;

                        modifyForm.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

                // Add controls to the form
                modifyForm.Controls.Add(itemComboBox);
                modifyForm.Controls.Add(itemDescriptionTextBox);
                modifyForm.Controls.Add(quantityTextBox);
                modifyForm.Controls.Add(okButton);

                // Show as dialog
                modifyForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewIssuance.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridViewIssuance.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridViewIssuance.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewIssuance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
