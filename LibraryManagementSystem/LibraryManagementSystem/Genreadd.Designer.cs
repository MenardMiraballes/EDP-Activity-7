namespace LibraryManagementSystem
{
    partial class Genreadd
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
            this.add_Genrename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addGenre_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_Genrename
            // 
            this.add_Genrename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Genrename.Location = new System.Drawing.Point(120, 46);
            this.add_Genrename.Margin = new System.Windows.Forms.Padding(4);
            this.add_Genrename.Name = "add_Genrename";
            this.add_Genrename.Size = new System.Drawing.Size(101, 21);
            this.add_Genrename.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "Genre Name:";
            // 
            // addGenre_btn
            // 
            this.addGenre_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addGenre_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGenre_btn.FlatAppearance.BorderSize = 0;
            this.addGenre_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addGenre_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addGenre_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGenre_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGenre_btn.ForeColor = System.Drawing.Color.White;
            this.addGenre_btn.Location = new System.Drawing.Point(44, 106);
            this.addGenre_btn.Name = "addGenre_btn";
            this.addGenre_btn.Size = new System.Drawing.Size(136, 43);
            this.addGenre_btn.TabIndex = 36;
            this.addGenre_btn.Text = "Add Genre";
            this.addGenre_btn.UseVisualStyleBackColor = false;
            this.addGenre_btn.Click += new System.EventHandler(this.addGenre_btn_Click);
            // 
            // Genreadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.add_Genrename);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addGenre_btn);
            this.Name = "Genreadd";
            this.Text = "Genreadd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_Genrename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addGenre_btn;
    }
}