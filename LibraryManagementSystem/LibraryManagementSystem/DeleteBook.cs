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

namespace LibraryManagementSystem
{
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
            // Assign an event handler to the Load event
            this.Load += AddBookForm_Load;
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            // Call the displayBookData method when the form loads
            displayBookData();
        }

        public void displayBookData()
        {
            DataAccess dataAccess = new DataAccess();
            dataGridView1.DataSource = dataAccess.FetchBookData();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
            {
                MessageBox.Show("No books available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addBook_Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int bookIdToDelete = int.Parse(deleteBook_id.Text);

                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Menard 18\Documents\libdb.mdf;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Books WHERE book_id = @bookId";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@bookId", bookIdToDelete);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book deleted successfully!");
                            displayBookData(); // Refresh the DataGridView after deletion
                        }
                        else
                        {
                            MessageBox.Show("No book found with the specified ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delete_returnbtn_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();
            mForm.Show();
            this.Hide();
        }
    }
}
