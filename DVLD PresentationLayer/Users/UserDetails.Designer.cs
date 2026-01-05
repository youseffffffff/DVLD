namespace DVLD_System
{
    partial class UserDetails
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
            this.grbLoginInformations = new System.Windows.Forms.GroupBox();
            this.lblIsActiveInfo = new System.Windows.Forms.Label();
            this.lblUserIDInfo = new System.Windows.Forms.Label();
            this.lblUserNameInfo = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.PersonDetails = new DVLD_System.PersonDetails();
            this.grbLoginInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLoginInformations
            // 
            this.grbLoginInformations.Controls.Add(this.lblIsActiveInfo);
            this.grbLoginInformations.Controls.Add(this.lblUserIDInfo);
            this.grbLoginInformations.Controls.Add(this.lblUserNameInfo);
            this.grbLoginInformations.Controls.Add(this.lblUserName);
            this.grbLoginInformations.Controls.Add(this.lblIsActive);
            this.grbLoginInformations.Controls.Add(this.lblUserID);
            this.grbLoginInformations.Location = new System.Drawing.Point(23, 425);
            this.grbLoginInformations.Name = "grbLoginInformations";
            this.grbLoginInformations.Size = new System.Drawing.Size(1126, 108);
            this.grbLoginInformations.TabIndex = 1;
            this.grbLoginInformations.TabStop = false;
            this.grbLoginInformations.Text = "Login Informations";
            // 
            // lblIsActiveInfo
            // 
            this.lblIsActiveInfo.AutoSize = true;
            this.lblIsActiveInfo.Font = new System.Drawing.Font("STFangsong", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIsActiveInfo.Location = new System.Drawing.Point(846, 56);
            this.lblIsActiveInfo.Name = "lblIsActiveInfo";
            this.lblIsActiveInfo.Size = new System.Drawing.Size(42, 23);
            this.lblIsActiveInfo.TabIndex = 7;
            this.lblIsActiveInfo.Text = "????";
            this.lblIsActiveInfo.Click += new System.EventHandler(this.lblIsActiveInfo_Click);
            // 
            // lblUserIDInfo
            // 
            this.lblUserIDInfo.AutoSize = true;
            this.lblUserIDInfo.Font = new System.Drawing.Font("STFangsong", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserIDInfo.Location = new System.Drawing.Point(306, 55);
            this.lblUserIDInfo.Name = "lblUserIDInfo";
            this.lblUserIDInfo.Size = new System.Drawing.Size(42, 23);
            this.lblUserIDInfo.TabIndex = 6;
            this.lblUserIDInfo.Text = "????";
            // 
            // lblUserNameInfo
            // 
            this.lblUserNameInfo.AutoSize = true;
            this.lblUserNameInfo.Font = new System.Drawing.Font("STFangsong", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserNameInfo.Location = new System.Drawing.Point(581, 56);
            this.lblUserNameInfo.Name = "lblUserNameInfo";
            this.lblUserNameInfo.Size = new System.Drawing.Size(42, 23);
            this.lblUserNameInfo.TabIndex = 5;
            this.lblUserNameInfo.Text = "????";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(433, 52);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(142, 27);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name :";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIsActive.Location = new System.Drawing.Point(724, 51);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(116, 27);
            this.lblIsActive.TabIndex = 3;
            this.lblIsActive.Text = "Is Active :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("STFangsong", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserID.Location = new System.Drawing.Point(191, 52);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(109, 27);
            this.lblUserID.TabIndex = 2;
            this.lblUserID.Text = "User ID :";
            // 
            // PersonDetails
            // 
            this.PersonDetails.Location = new System.Drawing.Point(0, 0);
            this.PersonDetails.Name = "PersonDetails";
            this.PersonDetails.Size = new System.Drawing.Size(1180, 429);
            this.PersonDetails.TabIndex = 0;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbLoginInformations);
            this.Controls.Add(this.PersonDetails);
            this.Name = "UserDetails";
            this.Size = new System.Drawing.Size(1182, 616);
            this.grbLoginInformations.ResumeLayout(false);
            this.grbLoginInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetails PersonDetails;
        private System.Windows.Forms.GroupBox grbLoginInformations;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblIsActiveInfo;
        private System.Windows.Forms.Label lblUserIDInfo;
        private System.Windows.Forms.Label lblUserNameInfo;
    }
}
