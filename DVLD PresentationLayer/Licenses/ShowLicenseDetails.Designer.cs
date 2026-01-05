namespace DVLD_System.Licenses
{
    partial class ShowLicenseDetails
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
            this.LicenseCard = new DVLD_System.Licenses.LicenseDetails();
            this.SuspendLayout();
            // 
            // LicenseCard
            // 
            this.LicenseCard.Location = new System.Drawing.Point(12, 12);
            this.LicenseCard.Name = "LicenseCard";
            this.LicenseCard.Size = new System.Drawing.Size(1276, 479);
            this.LicenseCard.TabIndex = 0;
            // 
            // ShowLicenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 503);
            this.Controls.Add(this.LicenseCard);
            this.Name = "ShowLicenseDetails";
            this.Text = "ShowLicenseDetails";
            this.Load += new System.EventHandler(this.ShowLicenseDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LicenseDetails LicenseCard;
    }
}