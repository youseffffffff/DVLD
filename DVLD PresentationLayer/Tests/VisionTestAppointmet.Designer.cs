namespace DVLD_System.Tests
{
    partial class VisionTestAppointmet
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
            this.components = new System.ComponentModel.Container();
            this.lblIcon = new System.Windows.Forms.Label();
            this.Appointments = new System.Windows.Forms.DataGridView();
            this.AppointmentOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAppointmet = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.picAddNewAppointment = new System.Windows.Forms.PictureBox();
            this.AppInfo = new DVLD_System.Applications.AppDetails();
            ((System.ComponentModel.ISupportInitialize)(this.Appointments)).BeginInit();
            this.AppointmentOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIcon
            // 
            this.lblIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIcon.AutoSize = true;
            this.lblIcon.Font = new System.Drawing.Font("Stencil", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.Location = new System.Drawing.Point(350, 34);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(699, 63);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "Vision Test Appointmet";
            // 
            // Appointments
            // 
            this.Appointments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Appointments.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appointments.ContextMenuStrip = this.AppointmentOptions;
            this.Appointments.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Appointments.Location = new System.Drawing.Point(1, 403);
            this.Appointments.Name = "Appointments";
            this.Appointments.ReadOnly = true;
            this.Appointments.RowHeadersWidth = 82;
            this.Appointments.RowTemplate.Height = 35;
            this.Appointments.Size = new System.Drawing.Size(1458, 247);
            this.Appointments.TabIndex = 2;
            // 
            // AppointmentOptions
            // 
            this.AppointmentOptions.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.AppointmentOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAppointmet,
            this.TakeTest});
            this.AppointmentOptions.Name = "AppOptions";
            this.AppointmentOptions.Size = new System.Drawing.Size(185, 80);
            // 
            // EditAppointmet
            // 
            this.EditAppointmet.Name = "EditAppointmet";
            this.EditAppointmet.Size = new System.Drawing.Size(184, 38);
            this.EditAppointmet.Text = "Edit";
            this.EditAppointmet.Click += new System.EventHandler(this.EditAppointmet_Click);
            // 
            // TakeTest
            // 
            this.TakeTest.Name = "TakeTest";
            this.TakeTest.Size = new System.Drawing.Size(184, 38);
            this.TakeTest.Text = "Take Test";
            this.TakeTest.Click += new System.EventHandler(this.TakeTest_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordsCount.Font = new System.Drawing.Font("Sitka Banner", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(18, 666);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(69, 39);
            this.lblRecordsCount.TabIndex = 7;
            this.lblRecordsCount.Text = "????";
            // 
            // picAddNewAppointment
            // 
            this.picAddNewAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAddNewAppointment.Image = global::DVLD_System.Properties.Resources.new_user;
            this.picAddNewAppointment.Location = new System.Drawing.Point(1379, 656);
            this.picAddNewAppointment.Name = "picAddNewAppointment";
            this.picAddNewAppointment.Size = new System.Drawing.Size(58, 55);
            this.picAddNewAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddNewAppointment.TabIndex = 8;
            this.picAddNewAppointment.TabStop = false;
            this.picAddNewAppointment.Click += new System.EventHandler(this.picAddNewAppointment_Click);
            // 
            // AppInfo
            // 
            this.AppInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AppInfo.Location = new System.Drawing.Point(1, 131);
            this.AppInfo.Name = "AppInfo";
            this.AppInfo.Size = new System.Drawing.Size(1458, 262);
            this.AppInfo.TabIndex = 1;
            // 
            // VisionTestAppointmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 723);
            this.Controls.Add(this.picAddNewAppointment);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.Appointments);
            this.Controls.Add(this.AppInfo);
            this.Controls.Add(this.lblIcon);
            this.Name = "VisionTestAppointmet";
            this.Text = "Vision Test Appointmet";
            this.Load += new System.EventHandler(this.VisionTestAppoinment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Appointments)).EndInit();
            this.AppointmentOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIcon;
        private Applications.AppDetails AppInfo;
        protected internal System.Windows.Forms.DataGridView Appointments;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.PictureBox picAddNewAppointment;
        private System.Windows.Forms.ContextMenuStrip AppointmentOptions;
        private System.Windows.Forms.ToolStripMenuItem EditAppointmet;
        private System.Windows.Forms.ToolStripMenuItem TakeTest;
    }
}