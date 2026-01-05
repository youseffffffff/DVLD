namespace DVLD_System.Licenses
{
    partial class LicenseDetailsWithFilter
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
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.txtBrimaryNumber = new System.Windows.Forms.TextBox();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.PictureBox();
            this.LicenseCard = new DVLD_System.Licenses.LicenseDetails();
            this.grbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFilter
            // 
            this.grbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFilter.Controls.Add(this.txtBrimaryNumber);
            this.grbFilter.Controls.Add(this.lblLicenseID);
            this.grbFilter.Controls.Add(this.Search);
            this.grbFilter.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFilter.Location = new System.Drawing.Point(34, 13);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(1218, 94);
            this.grbFilter.TabIndex = 10;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter";
            // 
            // txtBrimaryNumber
            // 
            this.txtBrimaryNumber.Location = new System.Drawing.Point(249, 36);
            this.txtBrimaryNumber.Name = "txtBrimaryNumber";
            this.txtBrimaryNumber.Size = new System.Drawing.Size(306, 32);
            this.txtBrimaryNumber.TabIndex = 4;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.Location = new System.Drawing.Point(93, 38);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(130, 26);
            this.lblLicenseID.TabIndex = 2;
            this.lblLicenseID.Text = "License ID:";
            // 
            // Search
            // 
            this.Search.Image = global::DVLD_System.Properties.Resources.optimization;
            this.Search.Location = new System.Drawing.Point(578, 38);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(60, 44);
            this.Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Search.TabIndex = 3;
            this.Search.TabStop = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LicenseCard
            // 
            this.LicenseCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseCard.Location = new System.Drawing.Point(18, 110);
            this.LicenseCard.Name = "LicenseCard";
            this.LicenseCard.Size = new System.Drawing.Size(1253, 743);
            this.LicenseCard.TabIndex = 0;
            // 
            // LicenseDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbFilter);
            this.Controls.Add(this.LicenseCard);
            this.Name = "LicenseDetailsWithFilter";
            this.Size = new System.Drawing.Size(1287, 866);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LicenseDetails LicenseCard;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.TextBox txtBrimaryNumber;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.PictureBox Search;
    }
}
