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

            // Set default date to today
            receivingDatePicker.Value = DateTime.Now;

            // Connect the combobox's selection changed event
            receivingItemCodeComboBox.SelectedIndexChanged += ReceivingItemCodeComboBox_SelectedIndexChanged;
        }

        private void LoadItemCodes()
        {
            try
            {
                string query = "SELECT item_code, item_description FROM items";
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

                // Get the selected item code (not the description)
                string itemCode = receivingItemCodeComboBox.Text;
                string itemDescription = receivingItemDescriptionTextBox.Text;

                // Get current user ID (replace with your actual user ID logic)
                int userId = 1; // Example, replace with actual user ID

                // Insert into database
                string insertQuery = @"INSERT INTO capex_receivings 
                                    (date_received, gr_number, item_code, item_description, quantity_added, user_id) 
                                    VALUES 
                                    (@date, @gr, @itemCode, @itemDesc, @quantity, @userId)";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@date", receivingDatePicker.Value.Date),
                    new MySqlParameter("@gr", grnumberTextBox.Text),
                    new MySqlParameter("@itemCode", itemCode),
                    new MySqlParameter("@itemDesc", itemDescription),
                    new MySqlParameter("@quantity", quantity),
                    new MySqlParameter("@userId", userId)
                };

                db.ExecuteNonQuery(insertQuery, parameters);

                MessageBox.Show("Receiving record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving receiving record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
