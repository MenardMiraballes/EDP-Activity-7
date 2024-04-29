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
    public partial class Authoradd : Form
    {
        public Authoradd()
        {
            InitializeComponent();
        }

        private void addAuthor_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve values from text fields
                string authorName = add_Authorname.Text;
                string nationality = add_Authornationality.Text;
                int birthYear = Convert.ToInt32(add_Authorbyear.Text);

                // Create connection string
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Menard 18\Documents\libdb.mdf;Integrated Security=True;Connect Timeout=30";

                // Create SQL query to insert data into Authors table
                string insertQuery = "INSERT INTO Authors (author_name, nationality, birth_year) VALUES (@authorName, @nationality, @birthYear); SELECT SCOPE_IDENTITY();";

                // Execute query and retrieve the newly inserted author ID
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@authorName", authorName);
                        command.Parameters.AddWithValue("@nationality", nationality);
                        command.Parameters.AddWithValue("@birthYear", birthYear);

                        // Execute the query and retrieve the newly inserted author ID
                        int authorId = Convert.ToInt32(command.ExecuteScalar());

                        // Optionally display a success message
                        MessageBox.Show("Author added successfully with ID: " + authorId);

                        // Close the current form and show the main form again
                        this.Close();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                // Display error message if an exception occurs
                MessageBox.Show("Error adding author: " + ex.Message);
            }
        }
    }
}
