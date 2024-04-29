using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBook : UserControl
    {
        public AddBook()
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addBook_Addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Menard 18\Documents\libdb.mdf;Integrated Security=True;Connect Timeout=30";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Books (title, author_id, genre_id, published_year, ISBN, available_quantity) VALUES (@title, @author_id, @genre_id, @published_year, @ISBN, @available_quantity)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@title", addBook_title.Text);
                        command.Parameters.AddWithValue("@author_id", int.Parse(addBook_Authorid.Text));
                        command.Parameters.AddWithValue("@genre_id", int.Parse(addBook_Genreid.Text));
                        command.Parameters.AddWithValue("@published_year", int.Parse(addBook_year.Text));
                        command.Parameters.AddWithValue("@ISBN", addBook_ISBN.Text);
                        command.Parameters.AddWithValue("@available_quantity", int.Parse(addBook_AvailQuant.Text));

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book added successfully!");
                            displayBookData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add book!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void addBook_Auth_Click(object sender, EventArgs e)
        {
            Authoradd addAuth = new Authoradd();
            addAuth.Show();
            this.Hide();
        }

        private void AddGenre_Click(object sender, EventArgs e)
        {
            Genreadd addGen = new Genreadd();
            addGen.Show();
            this.Hide();
        }

        private void addBook_Updatebtn_Click(object sender, EventArgs e)
        {
            UpdateBook uplbk = new UpdateBook();
            uplbk.Show();
            this.Hide();
        }

        private void addBook_Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteBook delbk = new DeleteBook();
            delbk.Show();
            this.Hide();
        }

        private void addBook_Clearbtn_Click(object sender, EventArgs e)
        {
            addBook_title.Text = string.Empty;
            addBook_Authorid.Text = string.Empty;
            addBook_Genreid.Text = string.Empty;
            addBook_year.Text = string.Empty;
            addBook_ISBN.Text = string.Empty;
            addBook_AvailQuant.Text = string.Empty;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }
    }
}
