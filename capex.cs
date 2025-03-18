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
    public partial class capex : Form
    {

        private Database db = new Database();

        public capex()
        {
            InitializeComponent();
            LoadItemCodes();
            LoadJobOrderTypes();
            LoadCapexStock();

            // Set default date to today
            receivingDatePicker.Value = DateTime.Now;

            // Connect the combobox's selection changed event
            receivingItemCodeComboBox.SelectedIndexChanged += ReceivingItemCodeComboBox_SelectedIndexChanged;

        }

        private void LoadItemCodes()
        {
            try
            {
                string query = "SELECT item_code, item_description FROM items WHERE item_type = 'Capex'";
                DataTable dt = db.ExecuteQuery(query);

                receivingItemCodeComboBox.DisplayMember = "item_code";
                receivingItemCodeComboBox.ValueMember = "item_description";
                receivingItemCodeComboBox.DataSource = dt;
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

                jobOrderTypeComboBox.DisplayMember = "job_order_type";
                jobOrderTypeComboBox.ValueMember = "job_description";
                jobOrderTypeComboBox.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading item codes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ReceivingItemCodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (receivingItemCodeComboBox.SelectedValue != null)
            {
                receivingItemDescriptionTextBox.Text = receivingItemCodeComboBox.SelectedValue.ToString();
            }
        }

        private void grnumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void receivingSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(grnumberTextBox.Text))
                {
                    MessageBox.Show("Please enter a GR Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (receivingItemCodeComboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select an item code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(receivingQuantityTextBox.Text, out decimal quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the selected item code and description
                string itemCode = receivingItemCodeComboBox.Text;
                string itemDescription = receivingItemDescriptionTextBox.Text;

                // Begin database transaction
                using (MySqlConnection conn = new MySqlConnection(db.ConnectionString))
                {
                    conn.Open();
                    using (MySqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Insert into capex_receivings
                            string insertReceivingQuery = @"INSERT INTO capex_receivings 
                        (date_received, gr_number, item_code, item_description, quantity_added) 
                        VALUES 
                        (@date, @gr, @itemCode, @itemDesc, @quantity)";

                            MySqlCommand cmdReceiving = new MySqlCommand(insertReceivingQuery, conn, transaction);
                            cmdReceiving.Parameters.AddWithValue("@date", receivingDatePicker.Value.Date);
                            cmdReceiving.Parameters.AddWithValue("@gr", grnumberTextBox.Text);
                            cmdReceiving.Parameters.AddWithValue("@itemCode", itemCode);
                            cmdReceiving.Parameters.AddWithValue("@itemDesc", itemDescription);
                            cmdReceiving.Parameters.AddWithValue("@quantity", quantity);
                            cmdReceiving.ExecuteNonQuery();

                            // Check if item exists in capex_stock
                            string checkStockQuery = "SELECT quantity FROM capex_stock WHERE item_code = @itemCode";
                            MySqlCommand cmdCheckStock = new MySqlCommand(checkStockQuery, conn, transaction);
                            cmdCheckStock.Parameters.AddWithValue("@itemCode", itemCode);
                            object existingQuantity = cmdCheckStock.ExecuteScalar();

                            if (existingQuantity != null)
                            {
                                // Item exists, update quantity
                                string updateStockQuery = "UPDATE capex_stock SET quantity = quantity + @quantity WHERE item_code = @itemCode";
                                MySqlCommand cmdUpdateStock = new MySqlCommand(updateStockQuery, conn, transaction);
                                cmdUpdateStock.Parameters.AddWithValue("@quantity", quantity);
                                cmdUpdateStock.Parameters.AddWithValue("@itemCode", itemCode);
                                cmdUpdateStock.ExecuteNonQuery();
                            }
                            else
                            {
                                // Item does not exist, insert new record
                                string insertStockQuery = "INSERT INTO capex_stock (item_code, item_description, quantity) VALUES (@itemCode, @itemDesc, @quantity)";
                                MySqlCommand cmdInsertStock = new MySqlCommand(insertStockQuery, conn, transaction);
                                cmdInsertStock.Parameters.AddWithValue("@itemCode", itemCode);
                                cmdInsertStock.Parameters.AddWithValue("@itemDesc", itemDescription);
                                cmdInsertStock.Parameters.AddWithValue("@quantity", quantity);
                                cmdInsertStock.ExecuteNonQuery();
                            }

                            // Commit transaction
                            transaction.Commit();

                            MessageBox.Show("Receiving record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the form
                            ClearForm();
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




        private void receivingClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            receivingDatePicker.Value = DateTime.Now;
            grnumberTextBox.Clear();
            receivingItemCodeComboBox.SelectedIndex = -1;
            receivingItemDescriptionTextBox.Clear();
            receivingQuantityTextBox.Clear();

            // Set focus to the first field
            grnumberTextBox.Focus();
        }

        private void LoadCapexStock()
        {
            try
            {
                string query = "SELECT item_code, item_description, quantity FROM capex_stock"; // Adjust columns if necessary
                DataTable dt = db.ExecuteQuery(query);

                dataGridViewCapexStock.DataSource = dt;
                dataGridViewCapexStock.AutoGenerateColumns = true;
                dataGridViewCapexStock.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Capex stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStockSearch_Click(object sender, EventArgs e)
        {

        }


        private void btnStockReset_Click(object sender, EventArgs e)
        {

        }


        private void receivingItemCodeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnStockSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = searchStockTextBox.Text.Trim();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    MessageBox.Show("Please enter a search term.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Modified query to search for partial matches in item_code or item_description
                string query = @"
            SELECT item_code, item_description, quantity 
            FROM capex_stock 
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

                dataGridViewCapexStock.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching Capex stock: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStockReset_Click_1(object sender, EventArgs e)
        {
            searchStockTextBox.Clear();
            LoadCapexStock();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create ContextMenuStrip
            ContextMenuStrip menu = new ContextMenuStrip();

            // Add item option
            ToolStripMenuItem addItem = new ToolStripMenuItem("Add Item");
            addItem.Click += addItemToolStripMenuItem_Click;
            menu.Items.Add(addItem);

            // Modify item option
            ToolStripMenuItem modifyItem = new ToolStripMenuItem("Modify Item");
            modifyItem.Click += modifyToolStripMenuItem_Click;
            menu.Items.Add(modifyItem);

            // Remove item option
            ToolStripMenuItem removeItem = new ToolStripMenuItem("Remove Item");
            removeItem.Click += removeToolStripMenuItem_Click;
            menu.Items.Add(removeItem);

            // Attach to DataGridView
            dataGridView1.ContextMenuStrip = menu;
        }


        private void AddItem_Click(object sender, EventArgs e)
        {

        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {

        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ensure DataGridView has columns before adding rows
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("item_code", "Item Code");
                dataGridView1.Columns.Add("item_description", "Item Description");
                dataGridView1.Columns.Add("quantity", "Quantity");
            }

            // Create the form for item selection
            Form addItemForm = new Form();
            addItemForm.Text = "Add Item";
            addItemForm.Size = new Size(350, 250);
            addItemForm.StartPosition = FormStartPosition.CenterParent;

            // Create dropdown for items
            ComboBox itemComboBox = new ComboBox() { Left = 20, Top = 20, Width = 200 };

            // Fetch item_code and item_description from capex_stock
            string query = "SELECT item_code, item_description FROM capex_stock";
            DataTable dt = db.ExecuteQuery(query);

            itemComboBox.DisplayMember = "item_code"; // Display item_code in dropdown
            itemComboBox.ValueMember = "item_description"; // Store item_description as Value
            itemComboBox.DataSource = dt;

            // Create textbox for item description (readonly)
            TextBox itemDescriptionTextBox = new TextBox() { Left = 20, Top = 60, Width = 300, ReadOnly = true };

            // Create textbox for quantity
            TextBox quantityTextBox = new TextBox() { Left = 20, Top = 100, Width = 200 };

            // Event to update item description when item is selected
            itemComboBox.SelectedIndexChanged += (s, args) =>
            {
                if (itemComboBox.SelectedValue != null)
                {
                    itemDescriptionTextBox.Text = itemComboBox.SelectedValue.ToString();
                }
            };

            // Create OK button
            Button okButton = new Button() { Text = "OK", Left = 100, Top = 140, Width = 100 };
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
                dataGridView1.Rows.Add(itemComboBox.Text, itemDescriptionTextBox.Text, quantity);
                addItemForm.Close();
            };

            // Add controls to the form
            addItemForm.Controls.Add(itemComboBox);
            addItemForm.Controls.Add(itemDescriptionTextBox);
            addItemForm.Controls.Add(quantityTextBox);
            addItemForm.Controls.Add(okButton);

            // Show as dialog
            addItemForm.ShowDialog();
        }


        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "Remove Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to modify.", "Modify Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string currentItemCode = selectedRow.Cells["item_code"].Value.ToString();
            string currentItemDescription = selectedRow.Cells["item_description"].Value.ToString();
            string currentQuantity = selectedRow.Cells["quantity"].Value.ToString();

            // Create the form for modification
            Form modifyForm = new Form();
            modifyForm.Text = "Modify Item";
            modifyForm.Size = new Size(350, 250);
            modifyForm.StartPosition = FormStartPosition.CenterParent;

            // Create dropdown for items
            ComboBox itemComboBox = new ComboBox() { Left = 20, Top = 20, Width = 200 };

            // Fetch item_code and item_description from capex_stock
            string query = "SELECT item_code, item_description FROM capex_stock";
            DataTable dt = db.ExecuteQuery(query);

            itemComboBox.DisplayMember = "item_code"; // Display item_code in dropdown
            itemComboBox.ValueMember = "item_description"; // Store item_description as Value
            itemComboBox.DataSource = dt;
            itemComboBox.Text = currentItemCode;

            // Create textbox for item description (readonly)
            TextBox itemDescriptionTextBox = new TextBox() { Left = 20, Top = 60, Width = 300, ReadOnly = true, Text = currentItemDescription };

            // Create textbox for quantity
            TextBox quantityTextBox = new TextBox() { Left = 20, Top = 100, Width = 200, Text = currentQuantity };

            // Event to update item description when item is selected
            itemComboBox.SelectedIndexChanged += (s, args) =>
            {
                if (itemComboBox.SelectedValue != null)
                {
                    itemDescriptionTextBox.Text = itemComboBox.SelectedValue.ToString();
                }
            };

            // Create OK button
            Button okButton = new Button() { Text = "OK", Left = 100, Top = 140, Width = 100 };
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

                // Update selected row
                selectedRow.Cells["item_code"].Value = itemComboBox.Text;
                selectedRow.Cells["item_description"].Value = itemDescriptionTextBox.Text;
                selectedRow.Cells["quantity"].Value = quantity;

                modifyForm.Close();
            };

            // Add controls to the form
            modifyForm.Controls.Add(itemComboBox);
            modifyForm.Controls.Add(itemDescriptionTextBox);
            modifyForm.Controls.Add(quantityTextBox);
            modifyForm.Controls.Add(okButton);

            // Show as dialog
            modifyForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate main form inputs
                if (string.IsNullOrWhiteSpace(requestedByTextBox.Text) ||
                    string.IsNullOrWhiteSpace(IssuedByTextBox.Text) ||
                    string.IsNullOrWhiteSpace(jobOrderTypeComboBox.Text) ||
                    string.IsNullOrWhiteSpace(meterNumberTextBox.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate DataGridView items
                if (dataGridView1.Rows.Count == 0)
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
                            // Insert into capex_issues table
                            string insertIssueQuery = @"INSERT INTO capex_issues 
                        (date_issued, requested_by, issued_by, jo_number, meter_number, remarks) 
                        VALUES (@dateIssued, @requestedBy, @issuedBy, @joNumber, @meterNumber, @remarks);
                        SELECT LAST_INSERT_ID();";

                            MySqlCommand cmdInsertIssue = new MySqlCommand(insertIssueQuery, conn, transaction);
                            cmdInsertIssue.Parameters.AddWithValue("@dateIssued", issuanceDatePicker.Value.Date);
                            cmdInsertIssue.Parameters.AddWithValue("@requestedBy", requestedByTextBox.Text);
                            cmdInsertIssue.Parameters.AddWithValue("@issuedBy", IssuedByTextBox.Text);
                            cmdInsertIssue.Parameters.AddWithValue("@joNumber", jobOrderTypeComboBox.Text);
                            cmdInsertIssue.Parameters.AddWithValue("@meterNumber", meterNumberTextBox.Text);
                            cmdInsertIssue.Parameters.AddWithValue("@remarks", remarksTextBox.Text);

                            int issueId = Convert.ToInt32(cmdInsertIssue.ExecuteScalar());

                            // Insert each item from DataGridView into capex_issue_items and update stock
                            foreach (DataGridViewRow row in dataGridView1.Rows)
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

                                // Insert into capex_issue_items
                                string insertItemQuery = @"INSERT INTO capex_issue_items 
                            (issue_id, item_code, item_description, quantity_issued) 
                            VALUES (@issueId, @itemCode, @itemDescription, @quantityIssued)";

                                MySqlCommand cmdInsertItem = new MySqlCommand(insertItemQuery, conn, transaction);
                                cmdInsertItem.Parameters.AddWithValue("@issueId", issueId);
                                cmdInsertItem.Parameters.AddWithValue("@itemCode", itemCode);
                                cmdInsertItem.Parameters.AddWithValue("@itemDescription", itemDescription);
                                cmdInsertItem.Parameters.AddWithValue("@quantityIssued", quantityIssued);
                                cmdInsertItem.ExecuteNonQuery();

                                // Subtract issued quantity from capex_stock
                                string updateStockQuery = @"UPDATE capex_stock 
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

                            // Clear form and DataGridView
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

        private void btnClearCapexIssuance_Click(object sender, EventArgs e)
        {
            issuanceDatePicker.Value = DateTime.Now;
            requestedByTextBox.Clear();
            IssuedByTextBox.Clear();
            jobOrderTypeComboBox.SelectedIndex = -1;
            meterNumberTextBox.Clear();
            remarksTextBox.Clear();
            dataGridView1.Rows.Clear(); // Clear DataGridView rows
        }
    }
}
