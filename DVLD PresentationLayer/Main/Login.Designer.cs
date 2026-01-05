namespace DVLD_System
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblDVLD = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btmLogin = new System.Windows.Forms.Button();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblLogin.Font = new System.Drawing.Font("Tempus Sans ITC", 25.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblLogin.Location = new System.Drawing.Point(408, 54);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(210, 91);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.Location = new System.Drawing.Point(551, 456);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 33);
            this.txtUserName.TabIndex = 1;
            // 
            // lblDVLD
            // 
            this.lblDVLD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDVLD.AutoSize = true;
            this.lblDVLD.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblDVLD.Font = new System.Drawing.Font("Tempus Sans ITC", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVLD.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDVLD.Location = new System.Drawing.Point(380, 145);
            this.lblDVLD.Name = "lblDVLD";
            this.lblDVLD.Size = new System.Drawing.Size(278, 56);
            this.lblDVLD.TabIndex = 2;
            this.lblDVLD.Text = "DVLD System";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblUserName.Font = new System.Drawing.Font("Tempus Sans ITC", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblUserName.Location = new System.Drawing.Point(349, 452);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(170, 38);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User  Name";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Font = new System.Drawing.Font("Tempus Sans ITC", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPassword.Location = new System.Drawing.Point(349, 536);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(135, 38);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(551, 540);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 33);
            this.txtPassword.TabIndex = 4;
            // 
            // btmLogin
            // 
            this.btmLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmLogin.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLogin.Location = new System.Drawing.Point(458, 667);
            this.btmLogin.Name = "btmLogin";
            this.btmLogin.Size = new System.Drawing.Size(137, 47);
            this.btmLogin.TabIndex = 6;
            this.btmLogin.Text = "Login";
            this.btmLogin.UseVisualStyleBackColor = true;
            this.btmLogin.Click += new System.EventHandler(this.Save_Click);
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Checked = true;
            this.RememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RememberMe.ForeColor = System.Drawing.Color.Cornsilk;
            this.RememberMe.Location = new System.Drawing.Point(432, 599);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(186, 31);
            this.RememberMe.TabIndex = 8;
            this.RememberMe.Text = "Remember Me";
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1083, 910);
            this.guna2GradientPanel1.TabIndex = 9;
            // 
            // Login
            // 
            this.AcceptButton = this.btmLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1083, 910);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.btmLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDVLD);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.guna2GradientPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblDVLD;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btmLogin;
        private System.Windows.Forms.CheckBox RememberMe;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}