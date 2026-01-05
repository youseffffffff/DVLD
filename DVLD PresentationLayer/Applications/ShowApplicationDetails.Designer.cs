namespace DVLD_System.Applications
{
    partial class ShowApplicationDetails
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
            this.AppDetails = new DVLD_System.Applications.AppDetails();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppDetails
            // 
            this.AppDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AppDetails.Location = new System.Drawing.Point(12, 290);
            this.AppDetails.Name = "AppDetails";
            this.AppDetails.Size = new System.Drawing.Size(1596, 445);
            this.AppDetails.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Urdu Typesetting", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(510, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(506, 104);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Applcation Details";
            // 
            // ShowApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 747);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.AppDetails);
            this.Name = "ShowApplicationDetails";
            this.Text = "ShowApplicationDetails";
            this.Load += new System.EventHandler(this.ShowApplicationDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppDetails AppDetails;
        private System.Windows.Forms.Label lblTitle;
    }
}