using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addBook1_Load(object sender, EventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to loguot?"
            , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            //addBook1.Visible = false;
            repDet1.Visible = false;
        }

        private void AddBook_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            //addBook1.Visible = true;
            repDet1.Visible = false;
        }

        private void RepGen_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            //addBook1.Visible = false;
            repDet1.Visible = true;
        }
    }
}
