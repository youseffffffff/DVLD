namespace DVLD_System.Detains
{
    partial class ReleaseLicenseDetain
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
            this.LocalLicense = new DVLD_System.Licenses.LicenseDetailsWithFilter();
            this.btmClose = new System.Windows.Forms.Button();
            this.btmRelease = new System.Windows.Forms.Button();
            this.grbReleaseAppInfo = new System.Windows.Forms.GroupBox();
            this.lblTotalFeesInfo = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblApplicationFeesInfo = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.txtFineFeesInfo = new System.Windows.Forms.TextBox();
            this.lblLicenseIDInfo = new System.Windows.Forms.Label();
            this.lblCreatedByInfo = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblDetainDateInfo = new System.Windows.Forms.Label();
            this.lblDetainIDInfo = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.lblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblShowLicenseDetails = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbReleaseAppInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocalLicense
            // 
            this.LocalLicense.FilterEnabled = true;
            this.LocalLicense.Location = new System.Drawing.Point(166, 112);
            this.LocalLicense.Name = "LocalLicense";
            this.LocalLicense.Size = new System.Drawing.Size(1284, 568);
            this.LocalLicense.TabIndex = 60;
            // 
            // btmClose
            // 
            this.btmClose.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmClose.Location = new System.Drawing.Point(1209, 945);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(119, 46);
            this.btmClose.TabIndex = 59;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btmRelease
            // 
            this.btmRelease.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmRelease.Location = new System.Drawing.Point(1347, 945);
            this.btmRelease.Name = "btmRelease";
            this.btmRelease.Size = new System.Drawing.Size(119, 46);
            this.btmRelease.TabIndex = 58;
            this.btmRelease.Text = "Release";
            this.btmRelease.UseVisualStyleBackColor = true;
            this.btmRelease.Click += new System.EventHandler(this.btmRelease_Click);
            // 
            // grbReleaseAppInfo
            // 
            this.grbReleaseAppInfo.Controls.Add(this.lblTotalFeesInfo);
            this.grbReleaseAppInfo.Controls.Add(this.lblTotalFees);
            this.grbReleaseAppInfo.Controls.Add(this.lblApplicationFeesInfo);
            this.grbReleaseAppInfo.Controls.Add(this.lblApplicationFees);
            this.grbReleaseAppInfo.Controls.Add(this.txtFineFeesInfo);
            this.grbReleaseAppInfo.Controls.Add(this.lblLicenseIDInfo);
            this.grbReleaseAppInfo.Controls.Add(this.lblCreatedByInfo);
            this.grbReleaseAppInfo.Controls.Add(this.lblCreatedBy);
            this.grbReleaseAppInfo.Controls.Add(this.lblDetainDateInfo);
            this.grbReleaseAppInfo.Controls.Add(this.lblDetainIDInfo);
            this.grbReleaseAppInfo.Controls.Add(this.lblLicenseID);
            this.grbReleaseAppInfo.Controls.Add(this.lblFineFees);
            this.grbReleaseAppInfo.Controls.Add(this.lblDetainDate);
            this.grbReleaseAppInfo.Controls.Add(this.lblDetainID);
            this.grbReleaseAppInfo.Location = new System.Drawing.Point(187, 676);
            this.grbReleaseAppInfo.Name = "grbReleaseAppInfo";
            this.grbReleaseAppInfo.Size = new System.Drawing.Size(1263, 263);
            this.grbReleaseAppInfo.TabIndex = 55;
            this.grbReleaseAppInfo.TabStop = false;
            this.grbReleaseAppInfo.Text = "Detain Info";
            // 
            // lblTotalFeesInfo
            // 
            this.lblTotalFeesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFeesInfo.AutoSize = true;
            this.lblTotalFeesInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesInfo.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFeesInfo.Location = new System.Drawing.Point(834, 171);
            this.lblTotalFeesInfo.Name = "lblTotalFeesInfo";
            this.lblTotalFeesInfo.Size = new System.Drawing.Size(58, 42);
            this.lblTotalFeesInfo.TabIndex = 36;
            this.lblTotalFeesInfo.Text = "????";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFees.Location = new System.Drawing.Point(686, 169);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(128, 44);
            this.lblTotalFees.TabIndex = 35;
            this.lblTotalFees.Text = "Total Fees:";
            // 
            // lblApplicationFeesInfo
            // 
            this.lblApplicationFeesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationFeesInfo.AutoSize = true;
            this.lblApplicationFeesInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesInfo.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFeesInfo.Location = new System.Drawing.Point(834, 129);
            this.lblApplicationFeesInfo.Name = "lblApplicationFeesInfo";
            this.lblApplicationFeesInfo.Size = new System.Drawing.Size(58, 42);
            this.lblApplicationFeesInfo.TabIndex = 34;
            this.lblApplicationFeesInfo.Text = "????";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(621, 129);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(193, 44);
            this.lblApplicationFees.TabIndex = 33;
            this.lblApplicationFees.Text = "Application Fees:";
            // 
            // txtFineFeesInfo
            // 
            this.txtFineFeesInfo.Location = new System.Drawing.Point(187, 137);
            this.txtFineFeesInfo.Name = "txtFineFeesInfo";
            this.txtFineFeesInfo.ReadOnly = true;
            this.txtFineFeesInfo.Size = new System.Drawing.Size(155, 33);
            this.txtFineFeesInfo.TabIndex = 32;
            // 
            // lblLicenseIDInfo
            // 
            this.lblLicenseIDInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenseIDInfo.AutoSize = true;
            this.lblLicenseIDInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseIDInfo.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseIDInfo.Location = new System.Drawing.Point(834, 42);
            this.lblLicenseIDInfo.Name = "lblLicenseIDInfo";
            this.lblLicenseIDInfo.Size = new System.Drawing.Size(58, 42);
            this.lblLicenseIDInfo.TabIndex = 30;
            this.lblLicenseIDInfo.Text = "????";
            // 
            // lblCreatedByInfo
            // 
            this.lblCreatedByInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedByInfo.AutoSize = true;
            this.lblCreatedByInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByInfo.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByInfo.Location = new System.Drawing.Point(834, 84);
            this.lblCreatedByInfo.Name = "lblCreatedByInfo";
            this.lblCreatedByInfo.Size = new System.Drawing.Size(58, 42);
            this.lblCreatedByInfo.TabIndex = 23;
            this.lblCreatedByInfo.Text = "????";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedBy.Location = new System.Drawing.Point(677, 81);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(137, 44);
            this.lblCreatedBy.TabIndex = 22;
            this.lblCreatedBy.Text = "Created By:";
            // 
            // lblDetainDateInfo
            // 
            this.lblDetainDateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetainDateInfo.AutoSize = true;
            this.lblDetainDateInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDateInfo.ForeColor = System.Drawing.Color.Black;
            this.lblDetainDateInfo.Location = new System.Drawing.Point(187, 84);
            this.lblDetainDateInfo.Name = "lblDetainDateInfo";
            this.lblDetainDateInfo.Size = new System.Drawing.Size(58, 42);
            this.lblDetainDateInfo.TabIndex = 16;
            this.lblDetainDateInfo.Text = "????";
            // 
            // lblDetainIDInfo
            // 
            this.lblDetainIDInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetainIDInfo.AutoSize = true;
            this.lblDetainIDInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainIDInfo.ForeColor = System.Drawing.Color.Black;
            this.lblDetainIDInfo.Location = new System.Drawing.Point(187, 40);
            this.lblDetainIDInfo.Name = "lblDetainIDInfo";
            this.lblDetainIDInfo.Size = new System.Drawing.Size(58, 42);
            this.lblDetainIDInfo.TabIndex = 14;
            this.lblDetainIDInfo.Text = "????";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseID.Location = new System.Drawing.Point(683, 39);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(131, 44);
            this.lblLicenseID.TabIndex = 13;
            this.lblLicenseID.Text = "License ID:";
            // 
            // lblFineFees
            // 
            this.lblFineFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.ForeColor = System.Drawing.Color.Black;
            this.lblFineFees.Location = new System.Drawing.Point(64, 127);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(117, 44);
            this.lblFineFees.TabIndex = 10;
            this.lblFineFees.Text = "Fine Fees:";
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ForeColor = System.Drawing.Color.Black;
            this.lblDetainDate.Location = new System.Drawing.Point(34, 81);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(147, 44);
            this.lblDetainDate.TabIndex = 8;
            this.lblDetainDate.Text = "Detain Date:";
            // 
            // lblDetainID
            // 
            this.lblDetainID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ForeColor = System.Drawing.Color.Black;
            this.lblDetainID.Location = new System.Drawing.Point(63, 37);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(124, 44);
            this.lblDetainID.TabIndex = 4;
            this.lblDetainID.Text = "Detain ID:";
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.AutoSize = true;
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(423, 951);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(218, 27);
            this.lblShowLicenseHistory.TabIndex = 57;
            this.lblShowLicenseHistory.TabStop = true;
            this.lblShowLicenseHistory.Text = "Show License History";
            this.lblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // lblShowLicenseDetails
            // 
            this.lblShowLicenseDetails.AutoSize = true;
            this.lblShowLicenseDetails.Enabled = false;
            this.lblShowLicenseDetails.Location = new System.Drawing.Point(185, 951);
            this.lblShowLicenseDetails.Name = "lblShowLicenseDetails";
            this.lblShowLicenseDetails.Size = new System.Drawing.Size(216, 27);
            this.lblShowLicenseDetails.TabIndex = 56;
            this.lblShowLicenseDetails.TabStop = true;
            this.lblShowLicenseDetails.Text = "Show License Details";
            this.lblShowLicenseDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseDetails_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Urdu Typesetting", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(584, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(438, 104);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Release License ";
            // 
            // ReleaseLicenseDetain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1187);
            this.Controls.Add(this.LocalLicense);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.btmRelease);
            this.Controls.Add(this.grbReleaseAppInfo);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.lblShowLicenseDetails);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReleaseLicenseDetain";
            this.Text = "ReleaseLicenseDetain";
            this.Load += new System.EventHandler(this.ReleaseLicenseDetain_Load);
            this.grbReleaseAppInfo.ResumeLayout(false);
            this.grbReleaseAppInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.LicenseDetailsWithFilter LocalLicense;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btmRelease;
        private System.Windows.Forms.GroupBox grbReleaseAppInfo;
        private System.Windows.Forms.TextBox txtFineFeesInfo;
        private System.Windows.Forms.Label lblLicenseIDInfo;
        private System.Windows.Forms.Label lblCreatedByInfo;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblDetainDateInfo;
        private System.Windows.Forms.Label lblDetainIDInfo;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.LinkLabel lblShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lblShowLicenseDetails;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotalFeesInfo;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblApplicationFeesInfo;
        private System.Windows.Forms.Label lblApplicationFees;
    }
}