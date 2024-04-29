using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using ClosedXML.Excel;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace LibraryManagementSystem
{
    public partial class RepDet : UserControl
    {
        public RepDet()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Load data from the Transactions table into the DataGridView
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Menard 18\Documents\libdb.mdf;Integrated Security=True;Connect Timeout=30";
                string query = "SELECT * FROM Transactions";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_rep.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Repdet_Exprtbtn_Click(object sender, EventArgs e)
        {
            // Get the data from the DataGridView
            DataTable dataTable = (DataTable)dataGridView_rep.DataSource;

            // Generate the Excel report
            ExcelReportGenerator.GenerateExcelReport(dataTable);
        }
    }
}
