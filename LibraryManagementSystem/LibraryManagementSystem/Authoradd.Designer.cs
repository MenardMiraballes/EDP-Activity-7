namespace LibraryManagementSystem
{
    partial class Authoradd
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_Authorbyear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.add_Authornationality = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_Authorname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addAuthor_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_Authorbyear
            // 
            this.add_Authorbyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Authorbyear.Location = new System.Drawing.Point(109, 139);
            this.add_Authorbyear.Margin = new System.Windows.Forms.Padding(4);
            this.add_Authorbyear.Name = "add_Authorbyear";
            this.add_Authorbyear.Size = new System.Drawing.Size(185, 21);
            this.add_Authorbyear.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Birth Year:";
            // 
            // add_Authornationality
            // 
            this.add_Authornationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Authornationality.Location = new System.Drawing.Point(109, 81);
            this.add_Authornationality.Margin = new System.Windows.Forms.Padding(4);
            this.add_Authornationality.Name = "add_Authornationality";
            this.add_Authornationality.Size = new System.Drawing.Size(185, 21);
            this.add_Authornationality.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Nationality:";
            // 
            // add_Authorname
            // 
            this.add_Authorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Authorname.Location = new System.Drawing.Point(109, 29);
            this.add_Authorname.Margin = new System.Windows.Forms.Padding(4);
            this.add_Authorname.Name = "add_Authorname";
            this.add_Authorname.Size = new System.Drawing.Size(185, 21);
            this.add_Authorname.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "Author Name:";
            // 
            // addAuthor_btn
            // 
            this.addAuthor_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addAuthor_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAuthor_btn.FlatAppearance.BorderSize = 0;
            this.addAuthor_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addAuthor_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addAuthor_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAuthor_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAuthor_btn.ForeColor = System.Drawing.Color.White;
            this.addAuthor_btn.Location = new System.Drawing.Point(88, 202);
            this.addAuthor_btn.Name = "addAuthor_btn";
            this.addAuthor_btn.Size = new System.Drawing.Size(136, 43);
            this.addAuthor_btn.TabIndex = 31;
            this.addAuthor_btn.Text = "Add Author";
            this.addAuthor_btn.UseVisualStyleBackColor = false;
            this.addAuthor_btn.Click += new System.EventHandler(this.addAuthor_btn_Click);
            // 
            // Authoradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 261);
            this.Controls.Add(this.add_Authorbyear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.add_Authornationality);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add_Authorname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addAuthor_btn);
            this.Name = "Authoradd";
            this.Text = "Authoradd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_Authorbyear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox add_Authornationality;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox add_Authorname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addAuthor_btn;
    }
}