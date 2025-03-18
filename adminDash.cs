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
    public partial class adminDash : Form
    {

        private Database db = new Database();

        public adminDash()
        {
            InitializeComponent();
            LoadUsers();

            // Attach double-click event
            usersDataGridView.CellDoubleClick += UsersDataGridView_CellDoubleClick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadUsers()
        {
            string query = "SELECT user_id, username, role, verification_status FROM users"; // Include 'id'
            DataTable usersTable = db.ExecuteQuery(query);
            usersDataGridView.DataSource = usersTable;

            // Hide ID column (optional)
            if (usersDataGridView.Columns["user_id"] != null)
                usersDataGridView.Columns["user_id"].Visible = false;
        }

        private void UsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is clicked
            {
                DataGridViewRow selectedRow = usersDataGridView.Rows[e.RowIndex];

                string userId = selectedRow.Cells["user_id"].Value.ToString();
                string currentStatus = selectedRow.Cells["verification_status"].Value.ToString();

                // Open the change status dialog
                string newStatus = ShowStatusDialog(currentStatus);

                if (!string.IsNullOrEmpty(newStatus) && newStatus != currentStatus)
                {
                    UpdateUserStatus(userId, newStatus);
                    LoadUsers(); // Refresh data
                }
            }
        }

        private string ShowStatusDialog(string currentStatus)
        {
            using (Form statusForm = new Form())
            {
                statusForm.Text = "Change Verification Status";
                statusForm.Size = new Size(300, 150);
                statusForm.StartPosition = FormStartPosition.CenterParent;
                statusForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                statusForm.MaximizeBox = false;
                statusForm.MinimizeBox = false;

                Label lbl = new Label() { Text = "Change Status:", Left = 20, Top = 20, Width = 250 };
                ComboBox comboBox = new ComboBox() { Left = 20, Top = 50, Width = 250 };
                comboBox.Items.AddRange(new string[] { "verified", "deactivated" });
                comboBox.SelectedItem = currentStatus;

                Button btnOK = new Button() { Text = "OK", Left = 20, Top = 90, Width = 100, DialogResult = DialogResult.OK };
                statusForm.AcceptButton = btnOK; // Allow Enter key to submit

                statusForm.Controls.Add(lbl);
                statusForm.Controls.Add(comboBox);
                statusForm.Controls.Add(btnOK);

                return (statusForm.ShowDialog() == DialogResult.OK) ? comboBox.SelectedItem.ToString() : null;
            }
        }

        private void UpdateUserStatus(string userId, string newStatus)
        {
            string query = "UPDATE users SET verification_status = @status WHERE user_id = @id";
            MySqlParameter[] parameters = {
                new MySqlParameter("@status", newStatus),
                new MySqlParameter("@id", userId)
            };

            int rowsAffected = db.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("User status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update user status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Implement logout logic
            this.Close();
            // Optionally, show login form again
            new adminLogin().Show();
        }
    }
}
