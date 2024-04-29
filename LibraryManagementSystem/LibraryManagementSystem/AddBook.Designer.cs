namespace LibraryManagementSystem
{
    partial class AddBook
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.AddGenre = new System.Windows.Forms.Button();
            this.addBook_Auth = new System.Windows.Forms.Button();
            this.addBook_AvailQuant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBook_Clearbtn = new System.Windows.Forms.Button();
            this.addBook_Deletebtn = new System.Windows.Forms.Button();
            this.addBook_Addbtn = new System.Windows.Forms.Button();
            this.addBook_Updatebtn = new System.Windows.Forms.Button();
            this.addBook_ISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBook_year = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addBook_Genreid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBook_Authorid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBook_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 217);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 162);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "WOODWARDEN\'S BOOKS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.AddGenre);
            this.panel2.Controls.Add(this.addBook_Auth);
            this.panel2.Controls.Add(this.addBook_AvailQuant);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addBook_Clearbtn);
            this.panel2.Controls.Add(this.addBook_Deletebtn);
            this.panel2.Controls.Add(this.addBook_Addbtn);
            this.panel2.Controls.Add(this.addBook_Updatebtn);
            this.panel2.Controls.Add(this.addBook_ISBN);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addBook_year);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addBook_Genreid);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addBook_Authorid);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addBook_title);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(14, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 152);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Add Author and Genre first";
            // 
            // AddGenre
            // 
            this.AddGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.AddGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddGenre.FlatAppearance.BorderSize = 0;
            this.AddGenre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.AddGenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.AddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGenre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGenre.ForeColor = System.Drawing.Color.White;
            this.AddGenre.Location = new System.Drawing.Point(82, 113);
            this.AddGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddGenre.Name = "AddGenre";
            this.AddGenre.Size = new System.Drawing.Size(60, 35);
            this.AddGenre.TabIndex = 22;
            this.AddGenre.Text = "Add Genre";
            this.AddGenre.UseVisualStyleBackColor = false;
            this.AddGenre.Click += new System.EventHandler(this.AddGenre_Click);
            // 
            // addBook_Auth
            // 
            this.addBook_Auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addBook_Auth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook_Auth.FlatAppearance.BorderSize = 0;
            this.addBook_Auth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addBook_Auth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addBook_Auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook_Auth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_Auth.ForeColor = System.Drawing.Color.White;
            this.addBook_Auth.Location = new System.Drawing.Point(17, 113);
            this.addBook_Auth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBook_Auth.Name = "addBook_Auth";
            this.addBook_Auth.Size = new System.Drawing.Size(60, 35);
            this.addBook_Auth.TabIndex = 21;
            this.addBook_Auth.Text = "Add Author";
            this.addBook_Auth.UseVisualStyleBackColor = false;
            this.addBook_Auth.Click += new System.EventHandler(this.addBook_Auth_Click);
            // 
            // addBook_AvailQuant
            // 
            this.addBook_AvailQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_AvailQuant.Location = new System.Drawing.Point(406, 80);
            this.addBook_AvailQuant.Name = "addBook_AvailQuant";
            this.addBook_AvailQuant.Size = new System.Drawing.Size(140, 21);
            this.addBook_AvailQuant.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Available Quantity:";
            // 
            // addBook_Clearbtn
            // 
            this.addBook_Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addBook_Clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook_Clearbtn.FlatAppearance.BorderSize = 0;
            this.addBook_Clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addBook_Clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addBook_Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook_Clearbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_Clearbtn.ForeColor = System.Drawing.Color.White;
            this.addBook_Clearbtn.Location = new System.Drawing.Point(464, 113);
            this.addBook_Clearbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBook_Clearbtn.Name = "addBook_Clearbtn";
            this.addBook_Clearbtn.Size = new System.Drawing.Size(76, 23);
            this.addBook_Clearbtn.TabIndex = 17;
            this.addBook_Clearbtn.Text = "Clear";
            this.addBook_Clearbtn.UseVisualStyleBackColor = false;
            this.addBook_Clearbtn.Click += new System.EventHandler(this.addBook_Clearbtn_Click);
            // 
            // addBook_Deletebtn
            // 
            this.addBook_Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addBook_Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook_Deletebtn.FlatAppearance.BorderSize = 0;
            this.addBook_Deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addBook_Deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addBook_Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook_Deletebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_Deletebtn.ForeColor = System.Drawing.Color.White;
            this.addBook_Deletebtn.Location = new System.Drawing.Point(383, 113);
            this.addBook_Deletebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBook_Deletebtn.Name = "addBook_Deletebtn";
            this.addBook_Deletebtn.Size = new System.Drawing.Size(76, 23);
            this.addBook_Deletebtn.TabIndex = 16;
            this.addBook_Deletebtn.Text = "Delete";
            this.addBook_Deletebtn.UseVisualStyleBackColor = false;
            this.addBook_Deletebtn.Click += new System.EventHandler(this.addBook_Deletebtn_Click);
            // 
            // addBook_Addbtn
            // 
            this.addBook_Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addBook_Addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook_Addbtn.FlatAppearance.BorderSize = 0;
            this.addBook_Addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addBook_Addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addBook_Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook_Addbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_Addbtn.ForeColor = System.Drawing.Color.White;
            this.addBook_Addbtn.Location = new System.Drawing.Point(223, 113);
            this.addBook_Addbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBook_Addbtn.Name = "addBook_Addbtn";
            this.addBook_Addbtn.Size = new System.Drawing.Size(76, 23);
            this.addBook_Addbtn.TabIndex = 15;
            this.addBook_Addbtn.Text = "Add";
            this.addBook_Addbtn.UseVisualStyleBackColor = false;
            this.addBook_Addbtn.Click += new System.EventHandler(this.addBook_Addbtn_Click);
            // 
            // addBook_Updatebtn
            // 
            this.addBook_Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addBook_Updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook_Updatebtn.FlatAppearance.BorderSize = 0;
            this.addBook_Updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addBook_Updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addBook_Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBook_Updatebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_Updatebtn.ForeColor = System.Drawing.Color.White;
            this.addBook_Updatebtn.Location = new System.Drawing.Point(303, 113);
            this.addBook_Updatebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBook_Updatebtn.Name = "addBook_Updatebtn";
            this.addBook_Updatebtn.Size = new System.Drawing.Size(76, 23);
            this.addBook_Updatebtn.TabIndex = 14;
            this.addBook_Updatebtn.Text = "Update";
            this.addBook_Updatebtn.UseVisualStyleBackColor = false;
            this.addBook_Updatebtn.Click += new System.EventHandler(this.addBook_Updatebtn_Click);
            // 
            // addBook_ISBN
            // 
            this.addBook_ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_ISBN.Location = new System.Drawing.Point(406, 47);
            this.addBook_ISBN.Name = "addBook_ISBN";
            this.addBook_ISBN.Size = new System.Drawing.Size(140, 21);
            this.addBook_ISBN.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "ISBN:";
            // 
            // addBook_year
            // 
            this.addBook_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_year.Location = new System.Drawing.Point(406, 20);
            this.addBook_year.Name = "addBook_year";
            this.addBook_year.Size = new System.Drawing.Size(140, 21);
            this.addBook_year.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(307, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Published Year:";
            // 
            // addBook_Genreid
            // 
            this.addBook_Genreid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_Genreid.Location = new System.Drawing.Point(73, 78);
            this.addBook_Genreid.Name = "addBook_Genreid";
            this.addBook_Genreid.Size = new System.Drawing.Size(140, 21);
            this.addBook_Genreid.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Genre ID:";
            // 
            // addBook_Authorid
            // 
            this.addBook_Authorid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_Authorid.Location = new System.Drawing.Point(73, 47);
            this.addBook_Authorid.Name = "addBook_Authorid";
            this.addBook_Authorid.Size = new System.Drawing.Size(140, 21);
            this.addBook_Authorid.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Author ID:";
            // 
            // addBook_title
            // 
            this.addBook_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBook_title.Location = new System.Drawing.Point(73, 18);
            this.addBook_title.Name = "addBook_title";
            this.addBook_title.Size = new System.Drawing.Size(140, 21);
            this.addBook_title.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title:";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddBook";
            this.Size = new System.Drawing.Size(613, 405);
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addBook_Authorid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addBook_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addBook_ISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addBook_year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addBook_Genreid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBook_Updatebtn;
        private System.Windows.Forms.Button addBook_Clearbtn;
        private System.Windows.Forms.Button addBook_Deletebtn;
        private System.Windows.Forms.Button addBook_Addbtn;
        private System.Windows.Forms.TextBox addBook_AvailQuant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddGenre;
        private System.Windows.Forms.Button addBook_Auth;
    }
}
