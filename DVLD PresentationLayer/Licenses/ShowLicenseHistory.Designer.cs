namespace DVLD_System.Licenses
{
    partial class ShowLicenseHistory
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
            this.ctrlDriverLicenses1 = new DVLD.Licenses.Local_Licenses.Controls.ctrlDriverLicenses();
            this.Person = new DVLD_System.PersonDetails();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Urdu Typesetting", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(323, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(663, 121);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Show License history";
            // 
            // ctrlDriverLicenses1
            // 
            this.ctrlDriverLicenses1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlDriverLicenses1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenses1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlDriverLicenses1.Location = new System.Drawing.Point(13, 564);
            this.ctrlDriverLicenses1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            this.ctrlDriverLicenses1.Size = new System.Drawing.Size(1411, 434);
            this.ctrlDriverLicenses1.TabIndex = 10;
            // 
            // Person
            // 
            this.Person.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Person.Location = new System.Drawing.Point(72, 138);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(1268, 373);
            this.Person.TabIndex = 0;
            // 
            // ShowLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 1012);
            this.Controls.Add(this.ctrlDriverLicenses1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.Person);
            this.Name = "ShowLicenseHistory";
            this.Text = "ShowLicenseHistory";
            this.Load += new System.EventHandler(this.ShowLicenseHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonDetails Person;
        private System.Windows.Forms.Label lblTitle;
        private DVLD.Licenses.Local_Licenses.Controls.ctrlDriverLicenses ctrlDriverLicenses1;
    }
}