namespace DVLD_System.Detains
{
    partial class AddNewDetain
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
            this.btmClose = new System.Windows.Forms.Button();
            this.btmDetain = new System.Windows.Forms.Button();
            this.grbDetainInfo = new System.Windows.Forms.GroupBox();
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
            this.LocalLicense = new DVLD_System.Licenses.LicenseDetailsWithFilter();
            this.grbDetainInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmClose
            // 
            this.btmClose.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmClose.Location = new System.Drawing.Point(1211, 904);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(119, 46);
            this.btmClose.TabIndex = 52;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btmDetain
            // 
            this.btmDetain.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDetain.Location = new System.Drawing.Point(1349, 904);
            this.btmDetain.Name = "btmDetain";
            this.btmDetain.Size = new System.Drawing.Size(119, 46);
            this.btmDetain.TabIndex = 51;
            this.btmDetain.Text = "Detain";
            this.btmDetain.UseVisualStyleBackColor = true;
            this.btmDetain.Click += new System.EventHandler(this.btmDetain_Click);
            // 
            // grbDetainInfo
            // 
            this.grbDetainInfo.Controls.Add(this.txtFineFeesInfo);
            this.grbDetainInfo.Controls.Add(this.lblLicenseIDInfo);
            this.grbDetainInfo.Controls.Add(this.lblCreatedByInfo);
            this.grbDetainInfo.Controls.Add(this.lblCreatedBy);
            this.grbDetainInfo.Controls.Add(this.lblDetainDateInfo);
            this.grbDetainInfo.Controls.Add(this.lblDetainIDInfo);
            this.grbDetainInfo.Controls.Add(this.lblLicenseID);
            this.grbDetainInfo.Controls.Add(this.lblFineFees);
            this.grbDetainInfo.Controls.Add(this.lblDetainDate);
            this.grbDetainInfo.Controls.Add(this.lblDetainID);
            this.grbDetainInfo.Location = new System.Drawing.Point(192, 703);
            this.grbDetainInfo.Name = "grbDetainInfo";
            this.grbDetainInfo.Size = new System.Drawing.Size(1263, 186);
            this.grbDetainInfo.TabIndex = 48;
            this.grbDetainInfo.TabStop = false;
            this.grbDetainInfo.Text = "Detain Info";
            // 
            // txtFineFeesInfo
            // 
            this.txtFineFeesInfo.Location = new System.Drawing.Point(187, 137);
            this.txtFineFeesInfo.Name = "txtFineFeesInfo";
            this.txtFineFeesInfo.Size = new System.Drawing.Size(155, 33);
            this.txtFineFeesInfo.TabIndex = 32;
            this.txtFineFeesInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFineFees_KeyPress);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(689, 82);
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
            this.lblLicenseID.Location = new System.Drawing.Point(686, 40);
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
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(425, 910);
            this.lblShowLicenseHistory.Name = "lblShowLicenseHistory";
            this.lblShowLicenseHistory.Size = new System.Drawing.Size(218, 27);
            this.lblShowLicenseHistory.TabIndex = 50;
            this.lblShowLicenseHistory.TabStop = true;
            this.lblShowLicenseHistory.Text = "Show License History";
            this.lblShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseHistory_LinkClicked);
            // 
            // lblShowLicenseDetails
            // 
            this.lblShowLicenseDetails.AutoSize = true;
            this.lblShowLicenseDetails.Enabled = false;
            this.lblShowLicenseDetails.Location = new System.Drawing.Point(187, 910);
            this.lblShowLicenseDetails.Name = "lblShowLicenseDetails";
            this.lblShowLicenseDetails.Size = new System.Drawing.Size(216, 27);
            this.lblShowLicenseDetails.TabIndex = 49;
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
            this.lblTitle.Location = new System.Drawing.Point(576, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(421, 104);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "Detain License ";
            // 
            // LocalLicense
            // 
            this.LocalLicense.FilterEnabled = true;
            this.LocalLicense.Location = new System.Drawing.Point(184, 129);
            this.LocalLicense.Name = "LocalLicense";
            this.LocalLicense.Size = new System.Drawing.Size(1284, 568);
            this.LocalLicense.TabIndex = 53;
            // 
            // AddNewDetain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1652, 1185);
            this.Controls.Add(this.LocalLicense);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.btmDetain);
            this.Controls.Add(this.grbDetainInfo);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.lblShowLicenseDetails);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddNewDetain";
            this.Text = "AddNewDetain";
            this.Load += new System.EventHandler(this.AddNewDetain_Load);
            this.grbDetainInfo.ResumeLayout(false);
            this.grbDetainInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.LicenseDetailsWithFilter LocalLicense;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btmDetain;
        private System.Windows.Forms.GroupBox grbDetainInfo;
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
        private System.Windows.Forms.TextBox txtFineFeesInfo;
    }
}