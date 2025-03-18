using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace InventoryManagement
{
    public class Database
    {
        // Connection string for XAMPP MySQL
        private string connectionString = "server=localhost;database=inventory_management;user=root;password=;";

        public string ConnectionString => connectionString; // Exposes connection string

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }


        // Method to execute a non-query (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        return cmd.ExecuteNonQuery(); // Returns the number of rows affected
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error executing non-query: " + ex.Message);
                }
            }
        }

        // Method to execute a query and return a DataTable (SELECT)
        public DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                        return dt; // Returns the result as a DataTable
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error executing query: " + ex.Message);
                }
            }
        }

        // Method to execute a query and return a single value (e.g., SELECT COUNT(*))
        public object ExecuteScalar(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        return cmd.ExecuteScalar(); // Returns the first column of the first row
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error executing scalar: " + ex.Message);
                }
            }
        }
    }
}