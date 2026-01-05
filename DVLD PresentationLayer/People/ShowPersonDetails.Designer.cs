namespace DVLD_System
{
    partial class ShowPersonDetails
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
            this.Person = new DVLD_System.PersonDetails();
            this.SuspendLayout();
            // 
            // Person
            // 
            this.Person.Location = new System.Drawing.Point(12, 23);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(1180, 429);
            this.Person.TabIndex = 0;
            // 
            // ShowPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 493);
            this.Controls.Add(this.Person);
            this.Name = "ShowPersonDetails";
            this.Text = "ShowPersonDetails";
            this.Load += new System.EventHandler(this.ShowPersonDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonDetails Person;
    }
}