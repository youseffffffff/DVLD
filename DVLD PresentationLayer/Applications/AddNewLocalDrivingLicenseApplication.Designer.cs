namespace DVLD_System
{
    partial class AddNewLocalDrivingLicenseApplication
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
            this.btmSave = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.TabControl();
            this.UserScreen = new System.Windows.Forms.TabPage();
            this.PersonScreen = new System.Windows.Forms.TabPage();
            this.grbAppInformations = new System.Windows.Forms.GroupBox();
            this.lblAppDateInfo = new System.Windows.Forms.Label();
            this.lblAppFeesInfo = new System.Windows.Forms.Label();
            this.lblCreateByInfo = new System.Windows.Forms.Label();
            this.lblCreateBy = new System.Windows.Forms.Label();
            this.lblDLAppIDnfo = new System.Windows.Forms.Label();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.Icon = new System.Windows.Forms.Label();
            this.Person = new DVLD_System.PersonDetailsByFiltering();
            this.cbLicenseClasses = new System.Windows.Forms.ComboBox();
            this.Details.SuspendLayout();
            this.UserScreen.SuspendLayout();
            this.PersonScreen.SuspendLayout();
            this.grbAppInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmClose
            // 
            this.btmClose.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmClose.Location = new System.Drawing.Point(1018, 731);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(120, 61);
            this.btmClose.TabIndex = 6;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btmSave
            // 
            this.btmSave.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSave.Location = new System.Drawing.Point(1158, 731);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(120, 61);
            this.btmSave.TabIndex = 5;
            this.btmSave.Text = "Save";
            this.btmSave.UseVisualStyleBackColor = true;
            this.btmSave.Click += new System.EventHandler(this.btmSave_Click);
            // 
            // Details
            // 
            this.Details.Controls.Add(this.UserScreen);
            this.Details.Controls.Add(this.PersonScreen);
            this.Details.Location = new System.Drawing.Point(38, 192);
            this.Details.Name = "Details";
            this.Details.SelectedIndex = 0;
            this.Details.Size = new System.Drawing.Size(1240, 533);
            this.Details.TabIndex = 4;
            // 
            // UserScreen
            // 
            this.UserScreen.Controls.Add(this.Person);
            this.UserScreen.Location = new System.Drawing.Point(8, 39);
            this.UserScreen.Name = "UserScreen";
            this.UserScreen.Padding = new System.Windows.Forms.Padding(3);
            this.UserScreen.Size = new System.Drawing.Size(1224, 486);
            this.UserScreen.TabIndex = 0;
            this.UserScreen.Text = "Person Screen";
            this.UserScreen.UseVisualStyleBackColor = true;
            // 
            // PersonScreen
            // 
            this.PersonScreen.Controls.Add(this.grbAppInformations);
            this.PersonScreen.Location = new System.Drawing.Point(8, 39);
            this.PersonScreen.Name = "PersonScreen";
            this.PersonScreen.Padding = new System.Windows.Forms.Padding(3);
            this.PersonScreen.Size = new System.Drawing.Size(1224, 486);
            this.PersonScreen.TabIndex = 1;
            this.PersonScreen.Text = "Application Screen Screen";
            this.PersonScreen.UseVisualStyleBackColor = true;
            // 
            // grbAppInformations
            // 
            this.grbAppInformations.Controls.Add(this.cbLicenseClasses);
            this.grbAppInformations.Controls.Add(this.lblAppDateInfo);
            this.grbAppInformations.Controls.Add(this.lblAppFeesInfo);
            this.grbAppInformations.Controls.Add(this.lblCreateByInfo);
            this.grbAppInformations.Controls.Add(this.lblCreateBy);
            this.grbAppInformations.Controls.Add(this.lblDLAppIDnfo);
            this.grbAppInformations.Controls.Add(this.lblLicenseClass);
            this.grbAppInformations.Controls.Add(this.lblAppDate);
            this.grbAppInformations.Controls.Add(this.lblAppFees);
            this.grbAppInformations.Controls.Add(this.lblDLAppID);
            this.grbAppInformations.Location = new System.Drawing.Point(46, 71);
            this.grbAppInformations.Name = "grbAppInformations";
            this.grbAppInformations.Size = new System.Drawing.Size(896, 412);
            this.grbAppInformations.TabIndex = 2;
            this.grbAppInformations.TabStop = false;
            this.grbAppInformations.Text = "Application Information";
            // 
            // lblAppDateInfo
            // 
            this.lblAppDateInfo.AutoSize = true;
            this.lblAppDateInfo.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAppDateInfo.Location = new System.Drawing.Point(355, 119);
            this.lblAppDateInfo.Name = "lblAppDateInfo";
            this.lblAppDateInfo.Size = new System.Drawing.Size(52, 27);
            this.lblAppDateInfo.TabIndex = 19;
            this.lblAppDateInfo.Text = "????";
            // 
            // lblAppFeesInfo
            // 
            this.lblAppFeesInfo.AutoSize = true;
            this.lblAppFeesInfo.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAppFeesInfo.Location = new System.Drawing.Point(355, 243);
            this.lblAppFeesInfo.Name = "lblAppFeesInfo";
            this.lblAppFeesInfo.Size = new System.Drawing.Size(52, 27);
            this.lblAppFeesInfo.TabIndex = 18;
            this.lblAppFeesInfo.Text = "????";
            // 
            // lblCreateByInfo
            // 
            this.lblCreateByInfo.AutoSize = true;
            this.lblCreateByInfo.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCreateByInfo.Location = new System.Drawing.Point(355, 302);
            this.lblCreateByInfo.Name = "lblCreateByInfo";
            this.lblCreateByInfo.Size = new System.Drawing.Size(52, 27);
            this.lblCreateByInfo.TabIndex = 17;
            this.lblCreateByInfo.Text = "????";
            // 
            // lblCreateBy
            // 
            this.lblCreateBy.AutoSize = true;
            this.lblCreateBy.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCreateBy.Location = new System.Drawing.Point(133, 296);
            this.lblCreateBy.Name = "lblCreateBy";
            this.lblCreateBy.Size = new System.Drawing.Size(118, 27);
            this.lblCreateBy.TabIndex = 15;
            this.lblCreateBy.Text = "CreateBy :";
            // 
            // lblDLAppIDnfo
            // 
            this.lblDLAppIDnfo.AutoSize = true;
            this.lblDLAppIDnfo.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDLAppIDnfo.Location = new System.Drawing.Point(355, 60);
            this.lblDLAppIDnfo.Name = "lblDLAppIDnfo";
            this.lblDLAppIDnfo.Size = new System.Drawing.Size(52, 27);
            this.lblDLAppIDnfo.TabIndex = 14;
            this.lblDLAppIDnfo.Text = "????";
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLicenseClass.Location = new System.Drawing.Point(89, 178);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(162, 27);
            this.lblLicenseClass.TabIndex = 12;
            this.lblLicenseClass.Text = "License Class :";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAppDate.Location = new System.Drawing.Point(52, 119);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(199, 27);
            this.lblAppDate.TabIndex = 4;
            this.lblAppDate.Text = "Application Date :";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAppFees.Location = new System.Drawing.Point(55, 237);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(196, 27);
            this.lblAppFees.TabIndex = 3;
            this.lblAppFees.Text = "Application Fees :";
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDLAppID.Location = new System.Drawing.Point(19, 60);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(232, 27);
            this.lblDLAppID.TabIndex = 2;
            this.lblDLAppID.Text = "D.L.Application ID : ";
            // 
            // Icon
            // 
            this.Icon.AutoSize = true;
            this.Icon.Font = new System.Drawing.Font("STHupo", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon.Location = new System.Drawing.Point(150, 44);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(1035, 71);
            this.Icon.TabIndex = 20;
            this.Icon.Text = "Add New Local Drivning License ";
            // 
            // Person
            // 
            this.Person.Location = new System.Drawing.Point(0, 0);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(1240, 559);
            this.Person.TabIndex = 0;
            // 
            // cbLicenseClasses
            // 
            this.cbLicenseClasses.FormattingEnabled = true;
            this.cbLicenseClasses.Location = new System.Drawing.Point(360, 172);
            this.cbLicenseClasses.Name = "cbLicenseClasses";
            this.cbLicenseClasses.Size = new System.Drawing.Size(159, 33);
            this.cbLicenseClasses.TabIndex = 20;
            // 
            // AddNewLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 816);
            this.Controls.Add(this.Icon);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.btmSave);
            this.Controls.Add(this.Details);
            this.Name = "AddNewLocalDrivingLicenseApplication";
            this.Text = "AddNewLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.AddNewLocalDrivingLicenseApplication_Load);
            this.Details.ResumeLayout(false);
            this.UserScreen.ResumeLayout(false);
            this.PersonScreen.ResumeLayout(false);
            this.grbAppInformations.ResumeLayout(false);
            this.grbAppInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btmSave;
        private System.Windows.Forms.TabControl Details;
        private System.Windows.Forms.TabPage UserScreen;
        private System.Windows.Forms.TabPage PersonScreen;
        private System.Windows.Forms.GroupBox grbAppInformations;
        private System.Windows.Forms.Label lblDLAppIDnfo;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label lblAppDateInfo;
        private System.Windows.Forms.Label lblAppFeesInfo;
        private System.Windows.Forms.Label lblCreateByInfo;
        private System.Windows.Forms.Label lblCreateBy;
        private System.Windows.Forms.Label Icon;
        private PersonDetailsByFiltering Person;
        private System.Windows.Forms.ComboBox cbLicenseClasses;
    }
}