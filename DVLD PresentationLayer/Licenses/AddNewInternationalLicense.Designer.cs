namespace DVLD_System.Licenses
{
    partial class AddNewInternationalLicense
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblShowLicenseDetails = new System.Windows.Forms.LinkLabel();
            this.lblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btmClose = new System.Windows.Forms.Button();
            this.btmSave = new System.Windows.Forms.Button();
            this.internationalApplicationDetails = new DVLD_System.Applications.InternationalApplicationDetails();
            this.LocalLicense = new DVLD_System.Licenses.LicenseDetailsWithFilter();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Urdu Typesetting", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(255, -3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(874, 104);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "International License Application";
            // 
            // lblShowLicenseDetails
            // 
            this.lblShowLicenseDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblShowLicenseDetails.AutoSize = true;
            this.lblShowLicenseDetails.Enabled = false;
            this.lblShowLicenseDetails.Location = new System.Drawing.Point(699, 885);
            this.lblShowLicenseDetails.Name = "lblShowLicenseDetails";
            this.lblShowLicenseDetails.Size = new System.Drawing.Size(216, 27);
            this.lblShowLicenseDetails.TabIndex = 11;
            this.lblShowLicenseDetails.TabStop = true;
            this.lblShowLicenseDetails.Text = "Show License Details";
            this.lblShowLicenseDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseDetails_LinkClicked);
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblShowLicenseHistory.AutoSize = true;
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(431, 885);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(218, 27);
            this.lblShowLicenseHistory.TabIndex = 12;
            this.lblShowLicenseHistory.TabStop = true;
            this.lblShowLicenseHistory.Text = "Show License History";
            this.lblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // btmClose
            // 
            this.btmClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btmClose.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmClose.Location = new System.Drawing.Point(46, 866);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(105, 46);
            this.btmClose.TabIndex = 41;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btmSave
            // 
            this.btmSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSave.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSave.Location = new System.Drawing.Point(1247, 866);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(105, 46);
            this.btmSave.TabIndex = 40;
            this.btmSave.Text = "Save";
            this.btmSave.UseVisualStyleBackColor = true;
            this.btmSave.Click += new System.EventHandler(this.btmSave_Click);
            // 
            // internationalApplicationDetails
            // 
            this.internationalApplicationDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.internationalApplicationDetails.Location = new System.Drawing.Point(247, 587);
            this.internationalApplicationDetails.Name = "internationalApplicationDetails";
            this.internationalApplicationDetails.Size = new System.Drawing.Size(912, 282);
            this.internationalApplicationDetails.TabIndex = 42;
            // 
            // LocalLicense
            // 
            this.LocalLicense.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LocalLicense.Location = new System.Drawing.Point(70, 84);
            this.LocalLicense.Name = "LocalLicense";
            this.LocalLicense.Size = new System.Drawing.Size(1264, 497);
            this.LocalLicense.TabIndex = 43;
            // 
            // AddNewInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 989);
            this.Controls.Add(this.internationalApplicationDetails);
            this.Controls.Add(this.LocalLicense);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.btmSave);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.lblShowLicenseDetails);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddNewInternationalLicense";
            this.Text = "AddNewInternationalLicense";
            this.Load += new System.EventHandler(this.AddNewInternationalLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lblShowLicenseDetails;
        private System.Windows.Forms.LinkLabel lblShowLicenseHistory;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btmSave;
        private Applications.InternationalApplicationDetails internationalApplicationDetails;
        private LicenseDetailsWithFilter LocalLicense;
    }
}