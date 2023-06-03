using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Project
{
    public partial class StaffScreen : Form
    {
        public StaffScreen()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=LAPTOP-78EFFK5G;Initial Catalog= db_salary;Integrated Security=True";

        private void ShowStaff_Click(object sender, EventArgs e)
        {
            // SQL query to select data from your database table
            string query = "SELECT * FROM staff";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlDataAdapter object
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    // Create a DataTable object to store the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
