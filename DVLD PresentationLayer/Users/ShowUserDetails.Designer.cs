namespace DVLD_System
{
    partial class ShowUserDetails
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
            this.User = new DVLD_System.UserDetails();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(-1, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(1182, 616);
            this.User.TabIndex = 0;
            // 
            // ShowUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 601);
            this.Controls.Add(this.User);
            this.Name = "ShowUserDetails";
            this.Text = "ShowUserDetails";
            this.Load += new System.EventHandler(this.ShowUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserDetails User;
    }
}