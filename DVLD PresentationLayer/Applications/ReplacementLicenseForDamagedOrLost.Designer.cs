namespace DVLD_System.Applications
{
    partial class ReplacementLicenseForDamagedOrLost
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
            this.btmReplace = new System.Windows.Forms.Button();
            this.grbApplicationNewLicenseInfo = new System.Windows.Forms.GroupBox();
            this.grbReplacementFor = new System.Windows.Forms.GroupBox();
            this.LostChoise = new System.Windows.Forms.RadioButton();
            this.DamagedChoise = new System.Windows.Forms.RadioButton();
            this.lblShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblShowLicenseDetails = new System.Windows.Forms.LinkLabel();
            this.txtNotesInfo = new System.Windows.Forms.TextBox();
            this.lblRenewedLicenseIDInfo = new System.Windows.Forms.Label();
            this.lblTotalFeesInfo = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblCreatedByInfo = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblExpirationDateinfo = new System.Windows.Forms.Label();
            this.lblLicenseFeesInfo = new System.Windows.Forms.Label();
            this.lblIssueDateInfo = new System.Windows.Forms.Label();
            this.lblOldLicenseIDInfo = new System.Windows.Forms.Label();
            this.lblApplicationDateInfo = new System.Windows.Forms.Label();
            this.lblApplicationFeesInfo = new System.Windows.Forms.Label();
            this.lblRenewLicenseAppIDInfo = new System.Windows.Forms.Label();
            this.lblRenewedLicenseID = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblLicenseFees = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblOldLicenseID = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblRenewLicenseAppID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.LocalLicense = new DVLD_System.Licenses.LicenseDetailsWithFilter();
            this.grbApplicationNewLicenseInfo.SuspendLayout();
            this.grbReplacementFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmReplace
            // 
            this.btmReplace.BackColor = System.Drawing.Color.Transparent;
            this.btmReplace.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmReplace.Location = new System.Drawing.Point(1314, 297);
            this.btmReplace.Name = "btmReplace";
            this.btmReplace.Size = new System.Drawing.Size(172, 70);
            this.btmReplace.TabIndex = 51;
            this.btmReplace.Text = "Replace";
            this.btmReplace.UseVisualStyleBackColor = false;
            this.btmReplace.Click += new System.EventHandler(this.btmReplace_Click);
            // 
            // grbApplicationNewLicenseInfo
            // 
            this.grbApplicationNewLicenseInfo.Controls.Add(this.grbReplacementFor);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.txtNotesInfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.btmReplace);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblRenewedLicenseIDInfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblTotalFeesInfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblTotalFees);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblCreatedByInfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblCreatedBy);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblExpirationDateinfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblLicenseFeesInfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblIssueDateInfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblOldLicenseIDInfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblApplicationDateInfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblApplicationFeesInfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblRenewLicenseAppIDInfo);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblRenewedLicenseID);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblNotes);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblLicenseFees);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblIssueDate);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblExpirationDate);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblOldLicenseID);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblApplicationDate);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblApplicationFees);
            this.grbApplicationNewLicenseInfo.Controls.Add(this.lblRenewLicenseAppID);
            this.grbApplicationNewLicenseInfo.Location = new System.Drawing.Point(27, 690);
            this.grbApplicationNewLicenseInfo.Name = "grbApplicationNewLicenseInfo";
            this.grbApplicationNewLicenseInfo.Size = new System.Drawing.Size(1505, 405);
            this.grbApplicationNewLicenseInfo.TabIndex = 48;
            this.grbApplicationNewLicenseInfo.TabStop = false;
            this.grbApplicationNewLicenseInfo.Text = "Application New License Info";
            // 
            // grbReplacementFor
            // 
            this.grbReplacementFor.Controls.Add(this.LostChoise);
            this.grbReplacementFor.Controls.Add(this.DamagedChoise);
            this.grbReplacementFor.Location = new System.Drawing.Point(896, 269);
            this.grbReplacementFor.Name = "grbReplacementFor";
            this.grbReplacementFor.Size = new System.Drawing.Size(401, 107);
            this.grbReplacementFor.TabIndex = 53;
            this.grbReplacementFor.TabStop = false;
            this.grbReplacementFor.Text = "Replacement For";
            // 
            // LostChoise
            // 
            this.LostChoise.AutoSize = true;
            this.LostChoise.Location = new System.Drawing.Point(117, 49);
            this.LostChoise.Name = "LostChoise";
            this.LostChoise.Size = new System.Drawing.Size(83, 31);
            this.LostChoise.TabIndex = 38;
            this.LostChoise.TabStop = true;
            this.LostChoise.Text = "Lost";
            this.LostChoise.UseVisualStyleBackColor = true;
            this.LostChoise.CheckedChanged += new System.EventHandler(this.LostChoise_CheckedChanged);
            // 
            // DamagedChoise
            // 
            this.DamagedChoise.AutoSize = true;
            this.DamagedChoise.BackColor = System.Drawing.Color.Transparent;
            this.DamagedChoise.Location = new System.Drawing.Point(227, 49);
            this.DamagedChoise.Name = "DamagedChoise";
            this.DamagedChoise.Size = new System.Drawing.Size(136, 31);
            this.DamagedChoise.TabIndex = 37;
            this.DamagedChoise.TabStop = true;
            this.DamagedChoise.Text = "Damaged";
            this.DamagedChoise.UseVisualStyleBackColor = false;
            this.DamagedChoise.CheckedChanged += new System.EventHandler(this.DamagedChoise_CheckedChanged);
            // 
            // lblShowLicenseHistory
            // 
            this.lblShowLicenseHistory.AutoSize = true;
            this.lblShowLicenseHistory.Location = new System.Drawing.Point(275, 1107);
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
            this.lblShowLicenseDetails.Location = new System.Drawing.Point(37, 1107);
            this.lblShowLicenseDetails.Name = "lblShowLicenseDetails";
            this.lblShowLicenseDetails.Size = new System.Drawing.Size(216, 27);
            this.lblShowLicenseDetails.TabIndex = 49;
            this.lblShowLicenseDetails.TabStop = true;
            this.lblShowLicenseDetails.Text = "Show License Details";
            this.lblShowLicenseDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowLicenseDetails_LinkClicked);
            // 
            // txtNotesInfo
            // 
            this.txtNotesInfo.Location = new System.Drawing.Point(238, 269);
            this.txtNotesInfo.Multiline = true;
            this.txtNotesInfo.Name = "txtNotesInfo";
            this.txtNotesInfo.Size = new System.Drawing.Size(652, 107);
            this.txtNotesInfo.TabIndex = 31;
            this.txtNotesInfo.TextChanged += new System.EventHandler(this.txtNotesInfo_TextChanged);
            // 
            // lblRenewedLicenseIDInfo
            // 
            this.lblRenewedLicenseIDInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenewedLicenseIDInfo.AutoSize = true;
            this.lblRenewedLicenseIDInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewedLicenseIDInfo.ForeColor = System.Drawing.Color.Black;
            this.lblRenewedLicenseIDInfo.Location = new System.Drawing.Point(832, 41);
            this.lblRenewedLicenseIDInfo.Name = "lblRenewedLicenseIDInfo";
            this.lblRenewedLicenseIDInfo.Size = new System.Drawing.Size(58, 42);
            this.lblRenewedLicenseIDInfo.TabIndex = 30;
            this.lblRenewedLicenseIDInfo.Text = "????";
            // 
            // lblTotalFeesInfo
            // 
            this.lblTotalFeesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFeesInfo.AutoSize = true;
            this.lblTotalFeesInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesInfo.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFeesInfo.Location = new System.Drawing.Point(832, 217);
            this.lblTotalFeesInfo.Name = "lblTotalFeesInfo";
            this.lblTotalFeesInfo.Size = new System.Drawing.Size(58, 42);
            this.lblTotalFeesInfo.TabIndex = 25;
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
            this.lblTotalFees.Location = new System.Drawing.Point(696, 215);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(128, 44);
            this.lblTotalFees.TabIndex = 24;
            this.lblTotalFees.Text = "Total Fees:";
            // 
            // lblCreatedByInfo
            // 
            this.lblCreatedByInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCreatedByInfo.AutoSize = true;
            this.lblCreatedByInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByInfo.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByInfo.Location = new System.Drawing.Point(832, 173);
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
            this.lblCreatedBy.Location = new System.Drawing.Point(687, 171);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(137, 44);
            this.lblCreatedBy.TabIndex = 22;
            this.lblCreatedBy.Text = "Created By:";
            // 
            // lblExpirationDateinfo
            // 
            this.lblExpirationDateinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpirationDateinfo.AutoSize = true;
            this.lblExpirationDateinfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDateinfo.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDateinfo.Location = new System.Drawing.Point(832, 129);
            this.lblExpirationDateinfo.Name = "lblExpirationDateinfo";
            this.lblExpirationDateinfo.Size = new System.Drawing.Size(58, 42);
            this.lblExpirationDateinfo.TabIndex = 20;
            this.lblExpirationDateinfo.Text = "????";
            // 
            // lblLicenseFeesInfo
            // 
            this.lblLicenseFeesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenseFeesInfo.AutoSize = true;
            this.lblLicenseFeesInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFeesInfo.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseFeesInfo.Location = new System.Drawing.Point(231, 217);
            this.lblLicenseFeesInfo.Name = "lblLicenseFeesInfo";
            this.lblLicenseFeesInfo.Size = new System.Drawing.Size(58, 42);
            this.lblLicenseFeesInfo.TabIndex = 19;
            this.lblLicenseFeesInfo.Text = "????";
            // 
            // lblIssueDateInfo
            // 
            this.lblIssueDateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIssueDateInfo.AutoSize = true;
            this.lblIssueDateInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDateInfo.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDateInfo.Location = new System.Drawing.Point(231, 129);
            this.lblIssueDateInfo.Name = "lblIssueDateInfo";
            this.lblIssueDateInfo.Size = new System.Drawing.Size(58, 42);
            this.lblIssueDateInfo.TabIndex = 18;
            this.lblIssueDateInfo.Text = "????";
            // 
            // lblOldLicenseIDInfo
            // 
            this.lblOldLicenseIDInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOldLicenseIDInfo.AutoSize = true;
            this.lblOldLicenseIDInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseIDInfo.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicenseIDInfo.Location = new System.Drawing.Point(832, 85);
            this.lblOldLicenseIDInfo.Name = "lblOldLicenseIDInfo";
            this.lblOldLicenseIDInfo.Size = new System.Drawing.Size(58, 42);
            this.lblOldLicenseIDInfo.TabIndex = 17;
            this.lblOldLicenseIDInfo.Text = "????";
            // 
            // lblApplicationDateInfo
            // 
            this.lblApplicationDateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationDateInfo.AutoSize = true;
            this.lblApplicationDateInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDateInfo.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDateInfo.Location = new System.Drawing.Point(231, 85);
            this.lblApplicationDateInfo.Name = "lblApplicationDateInfo";
            this.lblApplicationDateInfo.Size = new System.Drawing.Size(58, 42);
            this.lblApplicationDateInfo.TabIndex = 16;
            this.lblApplicationDateInfo.Text = "????";
            // 
            // lblApplicationFeesInfo
            // 
            this.lblApplicationFeesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationFeesInfo.AutoSize = true;
            this.lblApplicationFeesInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFeesInfo.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFeesInfo.Location = new System.Drawing.Point(231, 173);
            this.lblApplicationFeesInfo.Name = "lblApplicationFeesInfo";
            this.lblApplicationFeesInfo.Size = new System.Drawing.Size(58, 42);
            this.lblApplicationFeesInfo.TabIndex = 15;
            this.lblApplicationFeesInfo.Text = "????";
            // 
            // lblRenewLicenseAppIDInfo
            // 
            this.lblRenewLicenseAppIDInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenewLicenseAppIDInfo.AutoSize = true;
            this.lblRenewLicenseAppIDInfo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewLicenseAppIDInfo.ForeColor = System.Drawing.Color.Black;
            this.lblRenewLicenseAppIDInfo.Location = new System.Drawing.Point(231, 41);
            this.lblRenewLicenseAppIDInfo.Name = "lblRenewLicenseAppIDInfo";
            this.lblRenewLicenseAppIDInfo.Size = new System.Drawing.Size(58, 42);
            this.lblRenewLicenseAppIDInfo.TabIndex = 14;
            this.lblRenewLicenseAppIDInfo.Text = "????";
            // 
            // lblRenewedLicenseID
            // 
            this.lblRenewedLicenseID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenewedLicenseID.AutoSize = true;
            this.lblRenewedLicenseID.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewedLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblRenewedLicenseID.Location = new System.Drawing.Point(595, 39);
            this.lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            this.lblRenewedLicenseID.Size = new System.Drawing.Size(229, 44);
            this.lblRenewedLicenseID.TabIndex = 13;
            this.lblRenewedLicenseID.Text = "Renewed License ID:";
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.Black;
            this.lblNotes.Location = new System.Drawing.Point(146, 259);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(86, 44);
            this.lblNotes.TabIndex = 12;
            this.lblNotes.Text = "Notes:";
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLicenseFees.AutoSize = true;
            this.lblLicenseFees.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFees.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseFees.Location = new System.Drawing.Point(83, 215);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(149, 44);
            this.lblLicenseFees.TabIndex = 11;
            this.lblLicenseFees.Text = "License Fees:";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDate.Location = new System.Drawing.Point(108, 127);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(124, 44);
            this.lblIssueDate.TabIndex = 10;
            this.lblIssueDate.Text = "IssueDate:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDate.Location = new System.Drawing.Point(636, 127);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(188, 44);
            this.lblExpirationDate.TabIndex = 9;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOldLicenseID.AutoSize = true;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicenseID.Location = new System.Drawing.Point(650, 83);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(174, 44);
            this.lblOldLicenseID.TabIndex = 9;
            this.lblOldLicenseID.Text = "Old License ID:";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDate.Location = new System.Drawing.Point(34, 83);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(198, 44);
            this.lblApplicationDate.TabIndex = 8;
            this.lblApplicationDate.Text = "Application Date:";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(39, 171);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(193, 44);
            this.lblApplicationFees.TabIndex = 7;
            this.lblApplicationFees.Text = "Application Fees:";
            // 
            // lblRenewLicenseAppID
            // 
            this.lblRenewLicenseAppID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRenewLicenseAppID.AutoSize = true;
            this.lblRenewLicenseAppID.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenewLicenseAppID.ForeColor = System.Drawing.Color.Black;
            this.lblRenewLicenseAppID.Location = new System.Drawing.Point(15, 39);
            this.lblRenewLicenseAppID.Name = "lblRenewLicenseAppID";
            this.lblRenewLicenseAppID.Size = new System.Drawing.Size(217, 44);
            this.lblRenewLicenseAppID.TabIndex = 4;
            this.lblRenewLicenseAppID.Text = "R.L.Application ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Urdu Typesetting", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(293, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(868, 104);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "Replacement License Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // LocalLicense
            // 
            this.LocalLicense.Location = new System.Drawing.Point(40, 128);
            this.LocalLicense.Name = "LocalLicense";
            this.LocalLicense.Size = new System.Drawing.Size(1284, 568);
            this.LocalLicense.TabIndex = 54;
            // 
            // ReplacementLicenseForDamagedOrLost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 1239);
            this.Controls.Add(this.grbApplicationNewLicenseInfo);
            this.Controls.Add(this.lblShowLicenseHistory);
            this.Controls.Add(this.lblShowLicenseDetails);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.LocalLicense);
            this.Name = "ReplacementLicenseForDamagedOrLost";
            this.Text = "ReplacementLicenseForDamagedOrLost";
            this.Load += new System.EventHandler(this.ReplacementLicenseForDamagedOrLost_Load);
            this.grbApplicationNewLicenseInfo.ResumeLayout(false);
            this.grbApplicationNewLicenseInfo.PerformLayout();
            this.grbReplacementFor.ResumeLayout(false);
            this.grbReplacementFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btmReplace;
        private System.Windows.Forms.GroupBox grbApplicationNewLicenseInfo;
        private System.Windows.Forms.TextBox txtNotesInfo;
        private System.Windows.Forms.Label lblRenewedLicenseIDInfo;
        private System.Windows.Forms.Label lblTotalFeesInfo;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblCreatedByInfo;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblExpirationDateinfo;
        private System.Windows.Forms.Label lblLicenseFeesInfo;
        private System.Windows.Forms.Label lblIssueDateInfo;
        private System.Windows.Forms.Label lblOldLicenseIDInfo;
        private System.Windows.Forms.Label lblApplicationDateInfo;
        private System.Windows.Forms.Label lblApplicationFeesInfo;
        private System.Windows.Forms.Label lblRenewLicenseAppIDInfo;
        private System.Windows.Forms.Label lblRenewedLicenseID;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblLicenseFees;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblOldLicenseID;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblRenewLicenseAppID;
        private System.Windows.Forms.LinkLabel lblShowLicenseHistory;
        private System.Windows.Forms.LinkLabel lblShowLicenseDetails;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbReplacementFor;
        private System.Windows.Forms.RadioButton LostChoise;
        private System.Windows.Forms.RadioButton DamagedChoise;
        private Licenses.LicenseDetailsWithFilter LocalLicense;
    }
}