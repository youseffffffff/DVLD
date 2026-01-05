namespace DVLD_System.Licenses
{
    partial class IssueLicense
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
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btmClose = new System.Windows.Forms.Button();
            this.btmSave = new System.Windows.Forms.Button();
            this.appDetails1 = new DVLD_System.Applications.AppDetails();
            this.SuspendLayout();
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(23, 395);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(95, 39);
            this.lblNotes.TabIndex = 39;
            this.lblNotes.Text = "Notes :";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(24, 437);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(1207, 199);
            this.txtNotes.TabIndex = 38;
            // 
            // btmClose
            // 
            this.btmClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btmClose.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmClose.Location = new System.Drawing.Point(30, 709);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(105, 46);
            this.btmClose.TabIndex = 41;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btmSave
            // 
            this.btmSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSave.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSave.Location = new System.Drawing.Point(1115, 721);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(105, 46);
            this.btmSave.TabIndex = 40;
            this.btmSave.Text = "Save";
            this.btmSave.UseVisualStyleBackColor = true;
            this.btmSave.Click += new System.EventHandler(this.btmSave_Click);
            // 
            // appDetails1
            // 
            this.appDetails1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appDetails1.Location = new System.Drawing.Point(24, 27);
            this.appDetails1.Name = "appDetails1";
            this.appDetails1.Size = new System.Drawing.Size(1217, 356);
            this.appDetails1.TabIndex = 0;
            // 
            // IssueLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 803);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.btmSave);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.appDetails1);
            this.Name = "IssueLicense";
            this.Text = "IssueLicense";
            this.Load += new System.EventHandler(this.IssueLicense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btmSave;
        private Applications.AppDetails appDetails1;
    }
}