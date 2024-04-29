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
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
            // Assign an event handler to the Load event
            this.Load += UpdateBookForm_Load;
        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
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

        public class DataAccess
        {
            private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Menard 18\Documents\libdb.mdf;Integrated Security=True;Connect Timeout=30";

            public DataTable FetchBookData()
            {
                DataTable bookData = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Books";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);

                        try
                        {
                            connection.Open();
                            adapter.Fill(bookData);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error fetching book data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                return bookData;
            }

            public bool UpdateBook(int bookId, string title, int authorId, int genreId, int publishedYear, string isbn, int availableQuantity)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "UPDATE Books SET title = @title, author_id = @authorId, genre_id = @genreId, "
                                     + "published_year = @publishedYear, ISBN = @isbn, available_quantity = @availableQuantity "
                                     + "WHERE book_id = @bookId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@title", title);
                            command.Parameters.AddWithValue("@authorId", authorId);
                            command.Parameters.AddWithValue("@genreId", genreId);
                            command.Parameters.AddWithValue("@publishedYear", publishedYear);
                            command.Parameters.AddWithValue("@isbn", isbn);
                            command.Parameters.AddWithValue("@availableQuantity", availableQuantity);
                            command.Parameters.AddWithValue("@bookId", bookId);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void upBook_Updatebtn_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(upBook_id.Text);
            string title = upBook_title.Text;
            int authorId = int.Parse(upBook_Authorid.Text);
            int genreId = int.Parse(upBook_Genreid.Text);
            int publishedYear = int.Parse(upBook_year.Text);
            string isbn = upBook_ISBN.Text;
            int availableQuantity = int.Parse(upBook_AvailQuant.Text);

            try
            {
                // Check if the author ID exists in the Authors table
                if (!AuthorExists(authorId))
                {
                    MessageBox.Show("Author ID does not exist. Please provide a valid author ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the genre ID exists in the Genres table
                if (!GenreExists(genreId))
                {
                    MessageBox.Show("Genre ID does not exist. Please provide a valid genre ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update the book information in the database
                DataAccess dataAccess = new DataAccess();
                bool success = dataAccess.UpdateBook(bookId, title, authorId, genreId, publishedYear, isbn, availableQuantity);

                if (success)
                {
                    MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the DataGridView to reflect the changes
                    displayBookData();
                }
                else
                {
                    MessageBox.Show("Failed to update book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthorExists(int authorId)
        {
            // Query to check if the author ID exists in the Authors table
            string query = "SELECT COUNT(*) FROM Authors WHERE author_id = @authorId";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Menard 18\Documents\libdb.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@authorId", authorId);

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // If count > 0, the author ID exists; otherwise, it does not exist
                    return count > 0;
                }
            }
        }

        private bool GenreExists(int genreId)
        {
            // Query to check if the genre ID exists in the Genres table
            string query = "SELECT COUNT(*) FROM Genres WHERE genre_id = @genreId";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Menard 18\Documents\libdb.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@genreId", genreId);

                    // Open the connection
                    connection.Open();

                    // Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // If count > 0, the genre ID exists; otherwise, it does not exist
                    return count > 0;
                }
            }
        }

        private void upBook_Clearbtn_Click(object sender, EventArgs e)
        {
            upBook_id.Text = string.Empty;
            upBook_title.Text = string.Empty;
            upBook_Authorid.Text = string.Empty;
            upBook_Genreid.Text = string.Empty;
            upBook_year.Text = string.Empty;
            upBook_ISBN.Text = string.Empty;
            upBook_AvailQuant.Text = string.Empty;
        }

        private void update_returnbtn_Click(object sender, EventArgs e)
        {
            MainForm mForm = new MainForm();
            mForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
