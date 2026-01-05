namespace DVLD_System
{
    partial class ManageScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.btmAddNewRecord = new System.Windows.Forms.PictureBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.cbGendor = new System.Windows.Forms.ComboBox();
            this.Data = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmsAppTypeActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUserActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPersonActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLocalAppActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowAppDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.EditApp = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteApp = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelApp = new System.Windows.Forms.ToolStripMenuItem();
            this.Tests = new System.Windows.Forms.ToolStripMenuItem();
            this.VistionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.WrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.StreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTestTypeActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDetaainsActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReleaseOption = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDriverActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.icon = new System.Windows.Forms.PictureBox();
            this.grbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmAddNewRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.cmsAppTypeActions.SuspendLayout();
            this.cmsUserActions.SuspendLayout();
            this.cmsPersonActions.SuspendLayout();
            this.cmsLocalAppActions.SuspendLayout();
            this.cmsTestTypeActions.SuspendLayout();
            this.cmsDetaainsActions.SuspendLayout();
            this.cmsDriverActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordsCount.Font = new System.Drawing.Font("Sitka Banner", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblRecordsCount.Location = new System.Drawing.Point(12, 769);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(74, 42);
            this.lblRecordsCount.TabIndex = 10;
            this.lblRecordsCount.Text = "????";
            // 
            // grbFilter
            // 
            this.grbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbFilter.BackColor = System.Drawing.Color.Transparent;
            this.grbFilter.Controls.Add(this.btmAddNewRecord);
            this.grbFilter.Controls.Add(this.cbFilter);
            this.grbFilter.Controls.Add(this.lblFind);
            this.grbFilter.Controls.Add(this.txtFilter);
            this.grbFilter.Controls.Add(this.cbStatus);
            this.grbFilter.Controls.Add(this.cbIsActive);
            this.grbFilter.Controls.Add(this.cbGendor);
            this.grbFilter.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFilter.ForeColor = System.Drawing.Color.DarkBlue;
            this.grbFilter.Location = new System.Drawing.Point(0, 370);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(1705, 91);
            this.grbFilter.TabIndex = 8;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter";
            // 
            // btmAddNewRecord
            // 
            this.btmAddNewRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmAddNewRecord.BackColor = System.Drawing.Color.Transparent;
            this.btmAddNewRecord.Image = global::DVLD_System.Properties.Resources.icons8_add_new_24;
            this.btmAddNewRecord.Location = new System.Drawing.Point(1501, 20);
            this.btmAddNewRecord.Name = "btmAddNewRecord";
            this.btmAddNewRecord.Size = new System.Drawing.Size(104, 65);
            this.btmAddNewRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btmAddNewRecord.TabIndex = 5;
            this.btmAddNewRecord.TabStop = false;
            this.btmAddNewRecord.Click += new System.EventHandler(this.btmAddNewRecord_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(198, 37);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(197, 32);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.BackColor = System.Drawing.Color.Transparent;
            this.lblFind.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFind.Location = new System.Drawing.Point(93, 38);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(102, 26);
            this.lblFind.TabIndex = 2;
            this.lblFind.Text = "Find By:";
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilter.Location = new System.Drawing.Point(418, 38);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(305, 32);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.Visible = false;
            this.txtFilter.WordWrap = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Complete"});
            this.cbStatus.Location = new System.Drawing.Point(418, 38);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(305, 32);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.Status_SelectedIndexChanged);
            // 
            // cbIsActive
            // 
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(418, 38);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(305, 32);
            this.cbIsActive.TabIndex = 34;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // cbGendor
            // 
            this.cbGendor.FormattingEnabled = true;
            this.cbGendor.Items.AddRange(new object[] {
            "All",
            "Male",
            "Female"});
            this.cbGendor.Location = new System.Drawing.Point(418, 38);
            this.cbGendor.Name = "cbGendor";
            this.cbGendor.Size = new System.Drawing.Size(305, 32);
            this.cbGendor.TabIndex = 8;
            this.cbGendor.Visible = false;
            this.cbGendor.SelectedIndexChanged += new System.EventHandler(this.cbGendor_SelectedIndexChanged);
            // 
            // Data
            // 
            this.Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Data.ColumnHeadersHeight = 46;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Black", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data.GridColor = System.Drawing.Color.White;
            this.Data.Location = new System.Drawing.Point(0, 478);
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Data.RowHeadersWidth = 50;
            this.Data.RowTemplate.Height = 15;
            this.Data.RowTemplate.ReadOnly = true;
            this.Data.Size = new System.Drawing.Size(1705, 288);
            this.Data.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Playbill", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(2, 206);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1703, 110);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Manage Screen";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // cmsAppTypeActions
            // 
            this.cmsAppTypeActions.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsAppTypeActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cmsAppTypeActions.Name = "Options";
            this.cmsAppTypeActions.Size = new System.Drawing.Size(166, 42);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(165, 38);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // cmsUserActions
            // 
            this.cmsUserActions.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsUserActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.addNewUserToolStripMenuItem,
            this.showDetailsToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.cmsUserActions.Name = "UserActions";
            this.cmsUserActions.Size = new System.Drawing.Size(275, 194);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // cmsPersonActions
            // 
            this.cmsPersonActions.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsPersonActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editPersonInfoToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.cmsPersonActions.Name = "contextMenuStrip1";
            this.cmsPersonActions.Size = new System.Drawing.Size(226, 156);
            // 
            // editPersonInfoToolStripMenuItem
            // 
            this.editPersonInfoToolStripMenuItem.Name = "editPersonInfoToolStripMenuItem";
            this.editPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.editPersonInfoToolStripMenuItem.Text = "Edit";
            this.editPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.editPersonInfoToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(225, 38);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 38);
            this.toolStripMenuItem1.Text = "Show Details";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 38);
            this.toolStripMenuItem2.Text = "Delete";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cmsLocalAppActions
            // 
            this.cmsLocalAppActions.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsLocalAppActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowAppDetails,
            this.EditApp,
            this.DeleteApp,
            this.CancelApp,
            this.Tests,
            this.IssueLicense,
            this.ShowLicense,
            this.ShowLicenseHistory});
            this.cmsLocalAppActions.Name = "AppOptions";
            this.cmsLocalAppActions.Size = new System.Drawing.Size(436, 308);
            this.cmsLocalAppActions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsLocalAppActions_Opening);
            // 
            // ShowAppDetails
            // 
            this.ShowAppDetails.Name = "ShowAppDetails";
            this.ShowAppDetails.Size = new System.Drawing.Size(435, 38);
            this.ShowAppDetails.Text = "Show Application Details";
            this.ShowAppDetails.Click += new System.EventHandler(this.ShowAppDetails_Click);
            // 
            // EditApp
            // 
            this.EditApp.Name = "EditApp";
            this.EditApp.Size = new System.Drawing.Size(435, 38);
            this.EditApp.Text = "Edit Appliacton";
            this.EditApp.Click += new System.EventHandler(this.EditApp_Click);
            // 
            // DeleteApp
            // 
            this.DeleteApp.Name = "DeleteApp";
            this.DeleteApp.Size = new System.Drawing.Size(435, 38);
            this.DeleteApp.Text = "Delete Application";
            this.DeleteApp.Click += new System.EventHandler(this.DeleteApp_Click);
            // 
            // CancelApp
            // 
            this.CancelApp.Name = "CancelApp";
            this.CancelApp.Size = new System.Drawing.Size(435, 38);
            this.CancelApp.Text = "Cancel Application";
            this.CancelApp.Click += new System.EventHandler(this.CancelApp_Click);
            // 
            // Tests
            // 
            this.Tests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VistionTest,
            this.WrittenTest,
            this.StreetTest});
            this.Tests.Name = "Tests";
            this.Tests.Size = new System.Drawing.Size(435, 38);
            this.Tests.Text = "Sechdule Tests";
            // 
            // VistionTest
            // 
            this.VistionTest.Name = "VistionTest";
            this.VistionTest.Size = new System.Drawing.Size(380, 44);
            this.VistionTest.Text = "Sechdule Vistion Test";
            this.VistionTest.Click += new System.EventHandler(this.VistionTest_Click);
            // 
            // WrittenTest
            // 
            this.WrittenTest.Name = "WrittenTest";
            this.WrittenTest.Size = new System.Drawing.Size(380, 44);
            this.WrittenTest.Text = "Sechdule Written Test";
            this.WrittenTest.Click += new System.EventHandler(this.WrittenTest_Click);
            // 
            // StreetTest
            // 
            this.StreetTest.Name = "StreetTest";
            this.StreetTest.Size = new System.Drawing.Size(380, 44);
            this.StreetTest.Text = "Sechdule Street Test";
            this.StreetTest.Click += new System.EventHandler(this.StreetTest_Click);
            // 
            // IssueLicense
            // 
            this.IssueLicense.Name = "IssueLicense";
            this.IssueLicense.Size = new System.Drawing.Size(435, 38);
            this.IssueLicense.Text = "Issue Driving License (First Time)";
            this.IssueLicense.Click += new System.EventHandler(this.IssueLicense_Click);
            // 
            // ShowLicense
            // 
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.Size = new System.Drawing.Size(435, 38);
            this.ShowLicense.Text = "Show License";
            this.ShowLicense.Click += new System.EventHandler(this.ShowLicense_Click);
            // 
            // ShowLicenseHistory
            // 
            this.ShowLicenseHistory.Name = "ShowLicenseHistory";
            this.ShowLicenseHistory.Size = new System.Drawing.Size(435, 38);
            this.ShowLicenseHistory.Text = "Show License History";
            this.ShowLicenseHistory.Click += new System.EventHandler(this.showLicenseHistoryToolStripMenuItem_Click);
            // 
            // cmsTestTypeActions
            // 
            this.cmsTestTypeActions.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsTestTypeActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.cmsTestTypeActions.Name = "Options";
            this.cmsTestTypeActions.Size = new System.Drawing.Size(166, 42);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(165, 38);
            this.toolStripMenuItem3.Text = "Update";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // cmsDetaainsActions
            // 
            this.cmsDetaainsActions.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDetaainsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReleaseOption});
            this.cmsDetaainsActions.Name = "Options";
            this.cmsDetaainsActions.Size = new System.Drawing.Size(169, 42);
            this.cmsDetaainsActions.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDetaainsActions_Opening);
            // 
            // ReleaseOption
            // 
            this.ReleaseOption.Name = "ReleaseOption";
            this.ReleaseOption.Size = new System.Drawing.Size(168, 38);
            this.ReleaseOption.Text = "Release";
            this.ReleaseOption.Click += new System.EventHandler(this.ReleaseOption_Click);
            // 
            // cmsDriverActions
            // 
            this.cmsDriverActions.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.cmsDriverActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.cmsDriverActions.Name = "Options";
            this.cmsDriverActions.Size = new System.Drawing.Size(314, 42);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(313, 38);
            this.toolStripMenuItem4.Text = "Show License History";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // icon
            // 
            this.icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.Image = global::DVLD_System.Properties.Resources.icons8_add_new_24;
            this.icon.Location = new System.Drawing.Point(723, 3);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(229, 214);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 35;
            this.icon.TabStop = false;
            // 
            // ManageScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1707, 871);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.grbFilter);
            this.Controls.Add(this.Data);
            this.HelpButton = true;
            this.Name = "ManageScreen";
            this.Text = "ManageScreen";
            this.Load += new System.EventHandler(this.ManageScreen_Load);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btmAddNewRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.cmsAppTypeActions.ResumeLayout(false);
            this.cmsUserActions.ResumeLayout(false);
            this.cmsPersonActions.ResumeLayout(false);
            this.cmsLocalAppActions.ResumeLayout(false);
            this.cmsTestTypeActions.ResumeLayout(false);
            this.cmsDetaainsActions.ResumeLayout(false);
            this.cmsDriverActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.PictureBox btmAddNewRecord;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip cmsAppTypeActions;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsUserActions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsPersonActions;
        private System.Windows.Forms.ToolStripMenuItem editPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cmsLocalAppActions;
        private System.Windows.Forms.ToolStripMenuItem ShowAppDetails;
        private System.Windows.Forms.ToolStripMenuItem EditApp;
        private System.Windows.Forms.ToolStripMenuItem DeleteApp;
        private System.Windows.Forms.ToolStripMenuItem CancelApp;
        private System.Windows.Forms.ToolStripMenuItem Tests;
        private System.Windows.Forms.ToolStripMenuItem VistionTest;
        private System.Windows.Forms.ToolStripMenuItem WrittenTest;
        private System.Windows.Forms.ToolStripMenuItem StreetTest;
        private System.Windows.Forms.ToolStripMenuItem IssueLicense;
        private System.Windows.Forms.ToolStripMenuItem ShowLicense;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseHistory;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypeActions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbGendor;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip cmsDetaainsActions;
        private System.Windows.Forms.ToolStripMenuItem ReleaseOption;
        private System.Windows.Forms.ContextMenuStrip cmsDriverActions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.PictureBox icon;
    }
}