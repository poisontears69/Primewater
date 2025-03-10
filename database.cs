using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Primewater
{
    public class DatabaseConnection
    {
        // Database connection parameters
        private string server = "localhost";
        private string database = "primewater"; // Change to your database name
        private string uid = "root";            // Default XAMPP username
        private string password = "";           // Default XAMPP password (empty)
        private string port = "3306";           // Default MySQL port

        private MySqlConnection connection;
        private static DatabaseConnection _instance;

        // Singleton pattern to ensure only one database connection instance
        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseConnection();
                return _instance;
            }
        }

        // Constructor
        private DatabaseConnection()
        {
            Initialize();
        }

        // Initialize connection string
        private void Initialize()
        {
            string connectionString = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }

        // Open connection
        private bool OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator.");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password for database.");
                        break;
                    default:
                        MessageBox.Show($"Database connection error: {ex.Message}");
                        break;
                }
                return false;
            }
        }

        // Close connection
        private bool CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error closing connection: {ex.Message}");
                return false;
            }
        }

        // Execute query that returns a DataTable (SELECT)
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Query error: {ex.Message}");
                }
                finally
                {
                    CloseConnection();
                }
            }

            return dataTable;
        }

        // Execute query with parameters that returns a DataTable
        public DataTable ExecuteParameterizedQuery(string query, Dictionary<string, object> parameters)
        {
            DataTable dataTable = new DataTable();

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Add parameters
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Query error: {ex.Message}");
                }
                finally
                {
                    CloseConnection();
                }
            }

            return dataTable;
        }

        // Execute non-query (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query)
        {
            int affectedRows = 0;

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    affectedRows = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Query error: {ex.Message}");
                }
                finally
                {
                    CloseConnection();
                }
            }

            return affectedRows;
        }

        // Execute parameterized non-query (safer for INSERT, UPDATE, DELETE)
        public int ExecuteParameterizedNonQuery(string query, Dictionary<string, object> parameters)
        {
            int affectedRows = 0;

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Add parameters
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    affectedRows = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Query error: {ex.Message}");
                }
                finally
                {
                    CloseConnection();
                }
            }

            return affectedRows;
        }

        // Execute scalar query (returns a single value)
        public object ExecuteScalar(string query)
        {
            object result = null;

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    result = cmd.ExecuteScalar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Query error: {ex.Message}");
                }
                finally
                {
                    CloseConnection();
                }
            }

            return result;
        }

        // Example method for login verification
        public bool VerifyLogin(string username, string password)
        {
            bool loginSuccess = false;

            // Use parameterized query to prevent SQL injection
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@password", password } // Consider using hashed passwords in production
            };

            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    loginSuccess = (count > 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Login verification error: {ex.Message}");
                }
                finally
                {
                    CloseConnection();
                }
            }

            return loginSuccess;
        }
    }
}