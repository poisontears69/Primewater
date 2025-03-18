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
    public partial class Form1 : Form
    {

        private Database db = new Database();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            // Query to get user_id, password_hash, and verification_status
            string query = "SELECT user_id, password_hash, verification_status FROM users WHERE username = @username";
            MySqlParameter[] parameters = { new MySqlParameter("@username", username) };
            DataTable result = db.ExecuteQuery(query, parameters);

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Username does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve data
            int userId = Convert.ToInt32(result.Rows[0]["user_id"]);  // Fetch user_id
            string storedHash = result.Rows[0]["password_hash"].ToString();
            string verificationStatus = result.Rows[0]["verification_status"].ToString();
            string hashedPassword = HashPassword(password);

            if (storedHash != hashedPassword)
            {
                MessageBox.Show("Incorrect password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if account is awaiting approval
            if (verificationStatus == "awaiting approval")
            {
                MessageBox.Show("Your account is awaiting approval. Please wait for verification.", "Pending Approval", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if account is deactivated
            if (verificationStatus == "deactivated")
            {
                MessageBox.Show("Your account has been deactivated. Please contact support.", "Account Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ? Login successful ? Store user_id globally
            SessionData.UserId = userId;

            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            dashboard mainForm = new dashboard();
            mainForm.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the login form
            createAccount registerForm = new createAccount();
            registerForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            adminLogin adminLoginForm = new adminLogin();
            adminLoginForm.Show();
        }
    }

    public static class SessionData
    {
        public static int UserId { get; set; } = -1;
    }
}