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
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class RecoverForm : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Menard 18\Documents\library3.mdf;Integrated Security=True;Connect Timeout=30");
        public RecoverForm()
        {
            InitializeComponent();
        }

        private void recover_btn_Click(object sender, EventArgs e)
        {
            if (recover_username.Text == "" || recover_authenticator.Text == "" || recover_new_password.Text == "")
            {
                MessageBox.Show("Please fill all the fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT * FROM Users WHERE username = @username AND user_authentication = @authenticator";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", recover_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@authenticator", recover_authenticator.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string updatePassword = "UPDATE Users SET password = @password WHERE username = @username";
                                using (SqlCommand updateCmd = new SqlCommand(updatePassword, connect))
                                {
                                    updateCmd.Parameters.AddWithValue("@username", recover_username.Text.Trim());
                                    updateCmd.Parameters.AddWithValue("@password", recover_new_password.Text.Trim());

                                    updateCmd.ExecuteNonQuery();

                                    MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or authenticator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}
