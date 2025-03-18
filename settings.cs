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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Primewater
{
    public partial class settings : Form
    {
        private Database db = new Database();


        public settings()
        {
            InitializeComponent();
            LoadData();
            LoadItemsData("Capex");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jobCodeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void jobDescTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveJobType_Click(object sender, EventArgs e)
        {
            string jobCode = jobCodeTB.Text.Trim();
            string jobDesc = jobDescTB.Text.Trim();

            if (string.IsNullOrEmpty(jobCode) || string.IsNullOrEmpty(jobDesc))
            {
                MessageBox.Show("Please fill in both Job Code and Job Description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if job order type already exists
                string checkQuery = "SELECT COUNT(*) FROM job_orders WHERE job_order_type = @jobCode";
                MySqlParameter[] checkParams =
                {
            new MySqlParameter("@jobCode", jobCode)
        };

                int count = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams));

                if (count > 0)
                {
                    MessageBox.Show("A job order with this Job Code already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert new job order type
                string query = "INSERT INTO job_orders (job_order_type, job_order_description) VALUES (@jobCode, @jobDesc)";
                MySqlParameter[] parameters =
                {
            new MySqlParameter("@jobCode", jobCode),
            new MySqlParameter("@jobDesc", jobDesc)
        };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Job order type saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    jobCodeTB.Clear();
                    jobDescTB.Clear();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to save job order type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void itemCodeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemDescTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            string itemCode = itemCodeTB.Text.Trim();
            string itemDesc = itemDescTB.Text.Trim();
            string itemType = ""; // Variable to store selected type

            // Check which radio button is selected
            if (radioCapex.Checked)
            {
                itemType = "Capex";
            }
            else if (radioInventory.Checked)
            {
                itemType = "Inventory";
            }
            else
            {
                MessageBox.Show("Please select an item type (Capex or Inventory).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(itemCode) || string.IsNullOrEmpty(itemDesc))
            {
                MessageBox.Show("Please enter both Item Code and Item Description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if item already exists
                string checkQuery = "SELECT COUNT(*) FROM items WHERE item_code = @itemCode";
                MySqlParameter[] checkParams =
                {
            new MySqlParameter("@itemCode", itemCode)
        };

                int count = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams));

                if (count > 0)
                {
                    MessageBox.Show("An item with this Item Code already exists.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert new item with item_type
                string query = "INSERT INTO items (item_code, item_description, item_type) VALUES (@itemCode, @itemDesc, @itemType)";
                MySqlParameter[] parameters =
                {
            new MySqlParameter("@itemCode", itemCode),
            new MySqlParameter("@itemDesc", itemDesc),
            new MySqlParameter("@itemType", itemType)
        };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    itemCodeTB.Clear();
                    itemDescTB.Clear();
                    radioCapex.Checked = false;
                    radioInventory.Checked = false;
                    dataGridView2.Refresh(); // Force refresh
                }
                else
                {
                    MessageBox.Show("Failed to save item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadData()
        {
            try
            {
                string query = "SELECT job_order_id, job_order_type, job_order_description FROM job_orders"; // Adjust table name if needed
                DataTable dt = db.ExecuteQuery(query); // Fetch data using Database.cs

                dataGridView1.DataSource = dt; // Set data source to DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[rowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                }
            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int jobOrderId = Convert.ToInt32(row.Cells["job_order_id"].Value);
                string jobOrderType = row.Cells["job_order_type"].Value.ToString();
                string jobOrderDesc = row.Cells["job_order_description"].Value.ToString();

                string newJobOrderDesc = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter new job order description:", "Modify Job Order", jobOrderDesc);

                if (!string.IsNullOrEmpty(newJobOrderDesc))
                {
                    try
                    {
                        string query = "UPDATE job_orders SET job_order_description = @newDesc WHERE job_order_id = @jobOrderId";
                        MySqlParameter[] parameters =
                        {
                    new MySqlParameter("@newDesc", newJobOrderDesc),
                    new MySqlParameter("@jobOrderId", jobOrderId)
                };

                        int rowsAffected = db.ExecuteNonQuery(query, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Job order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh DataGridView
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating job order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int jobOrderId = Convert.ToInt32(row.Cells["job_order_id"].Value);
                string jobOrderType = row.Cells["job_order_type"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{jobOrderType}'?", "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM job_orders WHERE job_order_id = @jobOrderId";
                        MySqlParameter[] parameters =
                        {
                    new MySqlParameter("@jobOrderId", jobOrderId)
                };

                        int rowsAffected = db.ExecuteNonQuery(query, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Job order deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh DataGridView
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting job order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadItemsData(string itemType)
        {
            try
            {
                string query = "SELECT item_id, item_code, item_description, item_type FROM items WHERE item_type = @itemType"; // Filter by type
                MySqlParameter[] parameters = { new MySqlParameter("@itemType", itemType) };
                DataTable dt = db.ExecuteQuery(query, parameters); // Fetch filtered data

                dataGridView2.DataSource = null; // Clear previous data
                dataGridView2.DataSource = dt; // Set new data
                dataGridView2.AutoGenerateColumns = true; // Ensure columns generate automatically
                dataGridView2.Refresh(); // Force refresh
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowIndex = dataGridView2.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    dataGridView2.ClearSelection();
                    dataGridView2.Rows[rowIndex].Selected = true;
                    contextMenuStrip2.Show(dataGridView2, e.Location);
                }
            }
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void modifyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];

                int itemId = Convert.ToInt32(row.Cells["item_id"].Value);
                string itemCode = row.Cells["item_code"].Value.ToString();
                string itemDesc = row.Cells["item_description"].Value.ToString();

                string newItemDesc = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter new description:", "Modify Item", itemDesc);

                if (!string.IsNullOrEmpty(newItemDesc))
                {
                    try
                    {
                        string query = "UPDATE items SET item_description = @newDesc WHERE item_id = @id";
                        MySqlParameter[] parameters =
                        {
                    new MySqlParameter("@newDesc", newItemDesc),
                    new MySqlParameter("@id", itemId)
                };

                        int rowsAffected = db.ExecuteNonQuery(query, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView2.Refresh(); // Force refresh
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView2.SelectedRows[0];

                int itemId = Convert.ToInt32(row.Cells["item_id"].Value);
                string itemCode = row.Cells["item_code"].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete '{itemCode}'?", "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM items WHERE item_id = @id";
                        MySqlParameter[] parameters =
                        {
                    new MySqlParameter("@id", itemId)
                };

                        int rowsAffected = db.ExecuteNonQuery(query, parameters);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridView2.Refresh(); // Force refresh
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void radioCapex_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCapex.Checked)
            {
                radioInventory.Checked = false;
                LoadItemsData("Capex"); // Load only Capex items
            }
        }

        private void radioInventory_CheckedChanged(object sender, EventArgs e)
        {
            if (radioInventory.Checked)
            {
                radioCapex.Checked = false;
                LoadItemsData("Inventory"); // Load only Inventory items
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
