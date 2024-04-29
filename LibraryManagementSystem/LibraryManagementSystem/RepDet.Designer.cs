namespace LibraryManagementSystem
{
    partial class RepDet
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_rep = new System.Windows.Forms.DataGridView();
            this.Repdet_Exprtbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rep)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 131);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Detail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView_rep
            // 
            this.dataGridView_rep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rep.Location = new System.Drawing.Point(23, 151);
            this.dataGridView_rep.Name = "dataGridView_rep";
            this.dataGridView_rep.Size = new System.Drawing.Size(570, 198);
            this.dataGridView_rep.TabIndex = 1;
            // 
            // Repdet_Exprtbtn
            // 
            this.Repdet_Exprtbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.Repdet_Exprtbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Repdet_Exprtbtn.FlatAppearance.BorderSize = 0;
            this.Repdet_Exprtbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Repdet_Exprtbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.Repdet_Exprtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repdet_Exprtbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Repdet_Exprtbtn.ForeColor = System.Drawing.Color.White;
            this.Repdet_Exprtbtn.Location = new System.Drawing.Point(517, 368);
            this.Repdet_Exprtbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Repdet_Exprtbtn.Name = "Repdet_Exprtbtn";
            this.Repdet_Exprtbtn.Size = new System.Drawing.Size(76, 23);
            this.Repdet_Exprtbtn.TabIndex = 15;
            this.Repdet_Exprtbtn.Text = "Export";
            this.Repdet_Exprtbtn.UseVisualStyleBackColor = false;
            this.Repdet_Exprtbtn.Click += new System.EventHandler(this.Repdet_Exprtbtn_Click);
            // 
            // RepDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Repdet_Exprtbtn);
            this.Controls.Add(this.dataGridView_rep);
            this.Controls.Add(this.panel1);
            this.Name = "RepDet";
            this.Size = new System.Drawing.Size(613, 405);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_rep;
        private System.Windows.Forms.Button Repdet_Exprtbtn;
    }
}
