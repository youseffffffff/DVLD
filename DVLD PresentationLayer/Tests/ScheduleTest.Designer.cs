namespace DVLD_System.Tests
{
    partial class ScheduleTest
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
            this.ctrlScheduleTest = new DVLD_System.Tests.ctrlScheduleTest();
            this.SuspendLayout();
            // 
            // ctrlScheduleTest
            // 
            this.ctrlScheduleTest.Location = new System.Drawing.Point(16, 12);
            this.ctrlScheduleTest.Name = "ctrlScheduleTest";
            this.ctrlScheduleTest.Size = new System.Drawing.Size(870, 1174);
            this.ctrlScheduleTest.TabIndex = 35;
            this.ctrlScheduleTest.TestTypeID = DVLD_Business_Layer.clsTestType.enTestType.VisionTest;
            // 
            // ScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 1253);
            this.Controls.Add(this.ctrlScheduleTest);
            this.Name = "ScheduleTest";
            this.Text = "TakeAppointment";
            this.Load += new System.EventHandler(this.ScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlScheduleTest ctrlScheduleTest;
    }
}