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
    public partial class Genreadd : Form
    {
        public Genreadd()
        {
            InitializeComponent();
        }

        private void addGenre_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve genre name from text field
                string genreName = add_Genrename.Text;

                // Create connection string
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Menard 18\Documents\libdb.mdf;Integrated Security=True;Connect Timeout=30";

                // Create SQL query to insert data into Genres table
                string insertQuery = "INSERT INTO Genres (genre_name) VALUES (@genreName); SELECT SCOPE_IDENTITY();";

                // Execute query and retrieve the newly inserted genre ID
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@genreName", genreName);

                        // Execute the query and retrieve the newly inserted genre ID
                        int genreId = Convert.ToInt32(command.ExecuteScalar());

                        // Optionally display a success message
                        MessageBox.Show("Genre added successfully with ID: " + genreId);

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
                MessageBox.Show("Error adding genre: " + ex.Message);
            }
        }
    }
}
