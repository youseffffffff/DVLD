namespace DVLD_System.Applications
{
    partial class UpdateTestType
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
            this.btmClose = new System.Windows.Forms.Button();
            this.btmSave = new System.Windows.Forms.Button();
            this.lblIDInfo = new System.Windows.Forms.Label();
            this.txtTestFeesInfo = new System.Windows.Forms.TextBox();
            this.txtTestTitleInfo = new System.Windows.Forms.TextBox();
            this.lblTestFees = new System.Windows.Forms.Label();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUpdateTestType = new System.Windows.Forms.Label();
            this.txtTestDescriptionInfo = new System.Windows.Forms.TextBox();
            this.TestDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmClose
            // 
            this.btmClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmClose.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmClose.Location = new System.Drawing.Point(662, 809);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(120, 61);
            this.btmClose.TabIndex = 18;
            this.btmClose.Text = "Close";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btmSave
            // 
            this.btmSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmSave.Font = new System.Drawing.Font("Traditional Arabic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSave.Location = new System.Drawing.Point(822, 809);
            this.btmSave.Name = "btmSave";
            this.btmSave.Size = new System.Drawing.Size(120, 61);
            this.btmSave.TabIndex = 17;
            this.btmSave.Text = "Save";
            this.btmSave.UseVisualStyleBackColor = true;
            this.btmSave.Click += new System.EventHandler(this.btmSave_Click);
            // 
            // lblIDInfo
            // 
            this.lblIDInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIDInfo.AutoSize = true;
            this.lblIDInfo.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDInfo.Location = new System.Drawing.Point(309, 402);
            this.lblIDInfo.Name = "lblIDInfo";
            this.lblIDInfo.Size = new System.Drawing.Size(70, 31);
            this.lblIDInfo.TabIndex = 16;
            this.lblIDInfo.Text = "????";
            // 
            // txtTestFeesInfo
            // 
            this.txtTestFeesInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTestFeesInfo.Location = new System.Drawing.Point(288, 531);
            this.txtTestFeesInfo.Name = "txtTestFeesInfo";
            this.txtTestFeesInfo.Size = new System.Drawing.Size(206, 33);
            this.txtTestFeesInfo.TabIndex = 15;
            // 
            // txtTestTitleInfo
            // 
            this.txtTestTitleInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTestTitleInfo.Location = new System.Drawing.Point(288, 465);
            this.txtTestTitleInfo.Name = "txtTestTitleInfo";
            this.txtTestTitleInfo.Size = new System.Drawing.Size(206, 33);
            this.txtTestTitleInfo.TabIndex = 14;
            // 
            // lblTestFees
            // 
            this.lblTestFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTestFees.AutoSize = true;
            this.lblTestFees.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestFees.Location = new System.Drawing.Point(92, 533);
            this.lblTestFees.Name = "lblTestFees";
            this.lblTestFees.Size = new System.Drawing.Size(158, 31);
            this.lblTestFees.TabIndex = 13;
            this.lblTestFees.Text = "Test Fees :   ";
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTitle.Location = new System.Drawing.Point(89, 467);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(161, 31);
            this.lblTestTitle.TabIndex = 12;
            this.lblTestTitle.Text = "Test Title :   ";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(114, 402);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(136, 31);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "Test ID :   ";
            // 
            // lblUpdateTestType
            // 
            this.lblUpdateTestType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUpdateTestType.AutoSize = true;
            this.lblUpdateTestType.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTestType.Location = new System.Drawing.Point(265, 65);
            this.lblUpdateTestType.Name = "lblUpdateTestType";
            this.lblUpdateTestType.Size = new System.Drawing.Size(380, 55);
            this.lblUpdateTestType.TabIndex = 10;
            this.lblUpdateTestType.Text = "Update Test Type";
            // 
            // txtTestdescriptionInfo
            // 
            this.txtTestDescriptionInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTestDescriptionInfo.Location = new System.Drawing.Point(288, 589);
            this.txtTestDescriptionInfo.Multiline = true;
            this.txtTestDescriptionInfo.Name = "txtTestdescriptionInfo";
            this.txtTestDescriptionInfo.Size = new System.Drawing.Size(513, 159);
            this.txtTestDescriptionInfo.TabIndex = 20;
            // 
            // TestDescription
            // 
            this.TestDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TestDescription.AutoSize = true;
            this.TestDescription.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestDescription.Location = new System.Drawing.Point(12, 588);
            this.TestDescription.Name = "TestDescription";
            this.TestDescription.Size = new System.Drawing.Size(221, 31);
            this.TestDescription.TabIndex = 19;
            this.TestDescription.Text = "Test Description :";
            // 
            // UpdateTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 908);
            this.Controls.Add(this.txtTestDescriptionInfo);
            this.Controls.Add(this.TestDescription);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.btmSave);
            this.Controls.Add(this.lblIDInfo);
            this.Controls.Add(this.txtTestFeesInfo);
            this.Controls.Add(this.txtTestTitleInfo);
            this.Controls.Add(this.lblTestFees);
            this.Controls.Add(this.lblTestTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblUpdateTestType);
            this.Name = "UpdateTestType";
            this.Text = "UpdateTestType";
            this.Load += new System.EventHandler(this.UpdateTestType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.Button btmSave;
        private System.Windows.Forms.Label lblIDInfo;
        private System.Windows.Forms.TextBox txtTestFeesInfo;
        private System.Windows.Forms.TextBox txtTestTitleInfo;
        private System.Windows.Forms.Label lblTestFees;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUpdateTestType;
        private System.Windows.Forms.TextBox txtTestDescriptionInfo;
        private System.Windows.Forms.Label TestDescription;
    }
}