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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
            LoadHistoryLog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadHistoryLog()
        {
            try
            {
                Database db = new Database();
                string query = "SELECT action_type, action_detail, action_date FROM history_log ORDER BY action_date DESC";
                DataTable dt = db.ExecuteQuery(query);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history log: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadChart()
        {
        
        }



        private void DateButtonClicked(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistoryLog();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

        }
    }
}
