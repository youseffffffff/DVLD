namespace DVLD_System.Licenses
{
    partial class ShowInternationalLicenseDetails
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
            this.IntLicenseInfo = new DVLD_System.Licenses.InternationalLicenseDetails();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Urdu Typesetting", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(267, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(756, 104);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "International License Details";
            // 
            // IntLicenseInfo
            // 
            this.IntLicenseInfo.Location = new System.Drawing.Point(73, 181);
            this.IntLicenseInfo.Name = "IntLicenseInfo";
            this.IntLicenseInfo.Size = new System.Drawing.Size(1243, 480);
            this.IntLicenseInfo.TabIndex = 9;
            // 
            // ShowInternationalLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 732);
            this.Controls.Add(this.IntLicenseInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "ShowInternationalLicenseDetails";
            this.Text = "ShowInternationalLicenseDetails";
            this.Load += new System.EventHandler(this.ShowInternationalLicenseDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private InternationalLicenseDetails IntLicenseInfo;
    }
}