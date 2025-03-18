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
using System.Security.Cryptography;

namespace Primewater
{
    public partial class adminLogin : Form
    {
        private Database db = new Database();

        public adminLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void adminUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = adminUsername.Text.Trim();
            string password = adminPassword.Text;

            // Check if username exists
            string query = "SELECT password_hash, role FROM users WHERE username = @username";
            MySqlParameter[] parameters = { new MySqlParameter("@username", username) };
            DataTable result = db.ExecuteQuery(query, parameters);

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Username does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get stored password hash and role
            string storedHash = result.Rows[0]["password_hash"].ToString();
            string role = result.Rows[0]["role"].ToString();
            string hashedPassword = HashPassword(password);

            if (storedHash != hashedPassword)
            {
                MessageBox.Show("Incorrect password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (role.ToLower() != "admin")
            {
                MessageBox.Show("You are not an admin!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Admin login successful
            MessageBox.Show("Login successful!", "Welcome Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            adminDash adminDash = new adminDash();
            adminDash.Show();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
