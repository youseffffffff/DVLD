namespace DVLD_System
{
    partial class EditOrAddUser
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
            this.Details = new System.Windows.Forms.TabControl();
            this.UserScreen = new System.Windows.Forms.TabPage();
            this.Person = new DVLD_System.PersonDetails();
            this.PersonScreen = new System.Windows.Forms.TabPage();
            this.grbLoginInformations = new System.Windows.Forms.GroupBox();
            this.lblUserIDInfo = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblc = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.btmSave = new System.Windows.Forms.Button();
            this.btmClose = new System.Windows.Forms.Button();
            this.btmSelectUser = new System.Windows.Forms.Button();
            this.Details.SuspendLayout();
            this.UserScreen.SuspendLayout();
            this.PersonScreen.SuspendLayout();
            this.grbLoginInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // Details
            // 
            this.Details.Controls.Add(this.UserScreen);
            this.Details.Controls.Add(this.PersonScreen);
            this.Details.Location = new System.Drawing.Point(31, 123);
            this.Details.Name = "Details";
            this.Details.SelectedIndex = 0;
            this.Details.Size = new System.Drawing.Size(1240, 533);
            this.Details.TabIndex = 0;
            // 
            // UserScreen
            // 
            this.UserScreen.Controls.Add(this.btmSelectUser);
            this.UserScreen.Controls.Add(this.Person);
            this.UserScreen.Location = new System.Drawing.Point(8, 39);
            this.UserScreen.Name = "UserScreen";
            this.UserScreen.Padding = new System.Windows.Forms.Padding(3);
            this.UserScreen.Size = new System.Drawing.Size(1224, 486);
            this.UserScreen.TabIndex = 0;
            this.UserScreen.Text = "Person Screen";
            this.UserScreen.UseVisualStyleBackColor = true;
            // 
            // Person
            // 
            this.Person.Enabled = false;
            this.Person.Location = new System.Drawing.Point(6, 6);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(1180, 429);
            this.Person.TabIndex = 0;
            // 
            // PersonScreen
            // 
            this.PersonScreen.Controls.Add(this.grbLoginInformations);
            this.PersonScreen.Location = new System.Drawing.Point(8, 39);
            this.PersonScreen.Name = "PersonScreen";
            this.PersonScreen.Padding = new System.Windows.Forms.Padding(3);
            this.PersonScreen.Size = new System.Drawing.Size(1224, 486);
            this.PersonScreen.TabIndex = 1;
            this.PersonScreen.Text = "User Screen";
            this.PersonScreen.UseVisualStyleBackColor = true;
            // 
            // grbLoginInformations
            // 
            this.grbLoginInformations.Controls.Add(this.lblUserIDInfo);
            this.grbLoginInformations.Controls.Add(this.txtPassword);
            this.grbLoginInformations.Controls.Add(this.lblc);
            this.grbLoginInformations.Controls.Add(this.cbIsActive);
            this.grbLoginInformations.Controls.Add(this.txtUserName);
            this.grbLoginInformations.Controls.Add(this.lblUserName);
            this.grbLoginInformations.Controls.Add(this.lblIsActive);
            this.grbLoginInformations.Controls.Add(this.lblUserID);
            this.grbLoginInformations.Location = new System.Drawing.Point(46, 132);
            this.grbLoginInformations.Name = "grbLoginInformations";
            this.grbLoginInformations.Size = new System.Drawing.Size(404, 295);
            this.grbLoginInformations.TabIndex = 2;
            this.grbLoginInformations.TabStop = false;
            this.grbLoginInformations.Text = "Login Informations";
            // 
            // lblUserIDInfo
            // 
            this.lblUserIDInfo.AutoSize = true;
            this.lblUserIDInfo.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserIDInfo.Location = new System.Drawing.Point(205, 66);
            this.lblUserIDInfo.Name = "lblUserIDInfo";
            this.lblUserIDInfo.Size = new System.Drawing.Size(52, 27);
            this.lblUserIDInfo.TabIndex = 14;
            this.lblUserIDInfo.Text = "????";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(181, 180);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 33);
            this.txtPassword.TabIndex = 13;
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblc.Location = new System.Drawing.Point(52, 182);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(123, 27);
            this.lblc.TabIndex = 12;
            this.lblc.Text = "Password :";
            // 
            // cbIsActive
            // 
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(181, 235);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(174, 33);
            this.cbIsActive.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(181, 123);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 33);
            this.txtUserName.TabIndex = 9;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(33, 125);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(142, 27);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name :";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIsActive.Location = new System.Drawing.Point(59, 235);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(116, 27);
            this.lblIsActive.TabIndex = 3;
            this.lblIsActive.Text = "Is Active :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserID.Location = new System.Drawing.Point(66, 66);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(109, 27);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "User ID :";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("STFangsong", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.Crimson;
            this.lblIcon.Location = new System.Drawing.Point(445, 43);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(126, 72);
            this.lblIcon.TabIndex = 1;
            this.lblIcon.Text = "????";
            this.lblIcon.Click += new System.EventHandler(this.lblIcon_Click);
            // 
            // btmSave
            // 
            this.btmSave.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSave.Location = new System.Drawing.Point(1151, 662);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(120, 61);
            this.btmSave.TabIndex = 2;
            this.btmSave.Text = "Save";
            this.btmSave.UseVisualStyleBackColor = true;
            this.btmSave.Click += new System.EventHandler(this.btmSave_Click);
            // 
            // btmClose
            // 
            this.btmClose.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmClose.Location = new System.Drawing.Point(1011, 662);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(120, 61);
            this.btmClose.TabIndex = 3;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btmSelectUser
            // 
            this.btmSelectUser.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSelectUser.Location = new System.Drawing.Point(501, 417);
            this.btmSelectUser.Name = "btmSelectUser";
            this.btmSelectUser.Size = new System.Drawing.Size(156, 51);
            this.btmSelectUser.TabIndex = 4;
            this.btmSelectUser.Text = "Select User";
            this.btmSelectUser.UseVisualStyleBackColor = true;
            this.btmSelectUser.Click += new System.EventHandler(this.btmSelectUser_Click);
            // 
            // EditOrAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 772);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.btmSave);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.Details);
            this.Name = "EditOrAddUser";
            this.Text = "EditOrAddUser";
            this.Load += new System.EventHandler(this.EditOrAddUser_Load);
            this.Details.ResumeLayout(false);
            this.UserScreen.ResumeLayout(false);
            this.PersonScreen.ResumeLayout(false);
            this.grbLoginInformations.ResumeLayout(false);
            this.grbLoginInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Details;
        private System.Windows.Forms.TabPage UserScreen;
        private System.Windows.Forms.TabPage PersonScreen;
        private PersonDetails Person;
        private System.Windows.Forms.GroupBox grbLoginInformations;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Button btmSave;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Label lblUserIDInfo;
        private System.Windows.Forms.Button btmSelectUser;
    }
}