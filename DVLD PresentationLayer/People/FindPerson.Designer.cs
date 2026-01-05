namespace DVLD_System
{
    partial class FindPerson
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
            this.PersonFilter = new DVLD_System.PersonDetailsByFiltering();
            this.SuspendLayout();
            // 
            // PersonFilter
            // 
            this.PersonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonFilter.Location = new System.Drawing.Point(1, 0);
            this.PersonFilter.Name = "PersonFilter";
            this.PersonFilter.Size = new System.Drawing.Size(1228, 554);
            this.PersonFilter.TabIndex = 0;
            // 
            // FindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 566);
            this.Controls.Add(this.PersonFilter);
            this.Name = "FindPerson";
            this.Text = "FindUsercs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindPerson_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetailsByFiltering PersonFilter;
    }
}