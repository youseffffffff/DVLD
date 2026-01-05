namespace DVLD_System
{
    partial class PersonDetailsByFiltering
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
            this.cmbFindBy = new System.Windows.Forms.ComboBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.txtBrimaryNumber = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Person = new DVLD_System.PersonDetails();
            this.grbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFindBy
            // 
            this.cmbFindBy.FormattingEnabled = true;
            this.cmbFindBy.Items.AddRange(new object[] {
            "Person ID",
            "NationalNo"});
            this.cmbFindBy.Location = new System.Drawing.Point(198, 37);
            this.cmbFindBy.Name = "cmbFindBy";
            this.cmbFindBy.Size = new System.Drawing.Size(169, 32);
            this.cmbFindBy.TabIndex = 1;
            // 
            // lblFindBy
            // 
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindBy.Location = new System.Drawing.Point(93, 38);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(102, 26);
            this.lblFindBy.TabIndex = 2;
            this.lblFindBy.Text = "Find By:";
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.txtBrimaryNumber);
            this.grbFilter.Controls.Add(this.cmbFindBy);
            this.grbFilter.Controls.Add(this.lblFindBy);
            this.grbFilter.Controls.Add(this.pictureBox1);
            this.grbFilter.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFilter.Location = new System.Drawing.Point(47, 37);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(1158, 88);
            this.grbFilter.TabIndex = 3;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter";
            // 
            // txtBrimaryNumber
            // 
            this.txtBrimaryNumber.Location = new System.Drawing.Point(386, 36);
            this.txtBrimaryNumber.Name = "txtBrimaryNumber";
            this.txtBrimaryNumber.Size = new System.Drawing.Size(169, 32);
            this.txtBrimaryNumber.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_System.Properties.Resources.optimization;
            this.pictureBox1.Location = new System.Drawing.Point(585, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Person
            // 
            this.Person.Location = new System.Drawing.Point(47, 131);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(1158, 416);
            this.Person.TabIndex = 0;
            // 
            // PersonDetailsByFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbFilter);
            this.Controls.Add(this.Person);
            this.Name = "PersonDetailsByFiltering";
            this.Size = new System.Drawing.Size(1240, 559);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetails Person;
        private System.Windows.Forms.ComboBox cmbFindBy;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBrimaryNumber;
    }
}
