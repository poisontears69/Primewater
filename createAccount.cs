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
using MySql.Data.MySqlClient;
using InventoryManagement;

namespace Primewater
{
    public partial class createAccount : Form
    {

        private Database db = new Database();

        public createAccount()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            Form1 mainForm = new Form1();
            mainForm.Show();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if username is already taken
            string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
            MySqlParameter[] checkParams = { new MySqlParameter("@username", username) };
            object result = db.ExecuteScalar(checkQuery, checkParams);

            if (Convert.ToInt32(result) > 0)
            {
                MessageBox.Show("Username is already taken!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash the password
            string hashedPassword = HashPassword(password);

            // Insert new user into the database
            string insertQuery = "INSERT INTO users (username, password_hash, role, verification_status) VALUES (@username, @password, 'employee', 'awaiting approval')";
            MySqlParameter[] insertParams = {
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", hashedPassword)
            };

            int rowsAffected = db.ExecuteNonQuery(insertQuery, insertParams);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Hide the current form
                Form1 mainForm = new Form1();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Error creating account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
