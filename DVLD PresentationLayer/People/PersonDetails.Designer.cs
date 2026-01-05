namespace DVLD_System
{
    partial class PersonDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.Person = new System.Windows.Forms.GroupBox();
            this.lblEdit = new System.Windows.Forms.LinkLabel();
            this.PersonImage = new System.Windows.Forms.PictureBox();
            this.Data_lblPhone = new System.Windows.Forms.Label();
            this.Data_lblCountry = new System.Windows.Forms.Label();
            this.Data_lblGendor = new System.Windows.Forms.Label();
            this.Data_lblAddress = new System.Windows.Forms.Label();
            this.Data_lblEmail = new System.Windows.Forms.Label();
            this.Data_lblName = new System.Windows.Forms.Label();
            this.Data_lblNationalNo = new System.Windows.Forms.Label();
            this.Data_lblID = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGendor = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNationalNo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.Data_lblDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Urdu Typesetting", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(407, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 76);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Person Datails";
            // 
            // Person
            // 
            this.Person.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Person.Controls.Add(this.lblEdit);
            this.Person.Controls.Add(this.PersonImage);
            this.Person.Controls.Add(this.Data_lblPhone);
            this.Person.Controls.Add(this.Data_lblCountry);
            this.Person.Controls.Add(this.Data_lblGendor);
            this.Person.Controls.Add(this.Data_lblAddress);
            this.Person.Controls.Add(this.Data_lblEmail);
            this.Person.Controls.Add(this.Data_lblName);
            this.Person.Controls.Add(this.Data_lblNationalNo);
            this.Person.Controls.Add(this.Data_lblID);
            this.Person.Controls.Add(this.lblDateOfBirth);
            this.Person.Controls.Add(this.lblPhone);
            this.Person.Controls.Add(this.lblGendor);
            this.Person.Controls.Add(this.lblAddress);
            this.Person.Controls.Add(this.lblCountry);
            this.Person.Controls.Add(this.lblEmail);
            this.Person.Controls.Add(this.lblName);
            this.Person.Controls.Add(this.lblNationalNo);
            this.Person.Controls.Add(this.lblID);
            this.Person.Controls.Add(this.Data_lblDateOfBirth);
            this.Person.Location = new System.Drawing.Point(24, 79);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(1120, 324);
            this.Person.TabIndex = 3;
            this.Person.TabStop = false;
            this.Person.Text = "Person Informations";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(971, 47);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(48, 27);
            this.lblEdit.TabIndex = 22;
            this.lblEdit.TabStop = true;
            this.lblEdit.Text = "Edit";
            this.lblEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEdit_LinkClicked);
            // 
            // PersonImage
            // 
            this.PersonImage.Image = global::DVLD_System.Properties.Resources.man;
            this.PersonImage.Location = new System.Drawing.Point(915, 91);
            this.PersonImage.Name = "PersonImage";
            this.PersonImage.Size = new System.Drawing.Size(162, 162);
            this.PersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PersonImage.TabIndex = 4;
            this.PersonImage.TabStop = false;
            // 
            // Data_lblPhone
            // 
            this.Data_lblPhone.AutoSize = true;
            this.Data_lblPhone.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lblPhone.ForeColor = System.Drawing.Color.Black;
            this.Data_lblPhone.Location = new System.Drawing.Point(617, 180);
            this.Data_lblPhone.Name = "Data_lblPhone";
            this.Data_lblPhone.Size = new System.Drawing.Size(58, 42);
            this.Data_lblPhone.TabIndex = 21;
            this.Data_lblPhone.Text = "????";
            // 
            // Data_lblCountry
            // 
            this.Data_lblCountry.AutoSize = true;
            this.Data_lblCountry.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lblCountry.ForeColor = System.Drawing.Color.Black;
            this.Data_lblCountry.Location = new System.Drawing.Point(617, 216);
            this.Data_lblCountry.Name = "Data_lblCountry";
            this.Data_lblCountry.Size = new System.Drawing.Size(58, 42);
            this.Data_lblCountry.TabIndex = 20;
            this.Data_lblCountry.Text = "????";
            // 
            // Data_lblGendor
            // 
            this.Data_lblGendor.AutoSize = true;
            this.Data_lblGendor.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lblGendor.ForeColor = System.Drawing.Color.Black;
            this.Data_lblGendor.Location = new System.Drawing.Point(154, 173);
            this.Data_lblGendor.Name = "Data_lblGendor";
            this.Data_lblGendor.Size = new System.Drawing.Size(58, 42);
            this.Data_lblGendor.TabIndex = 19;
            this.Data_lblGendor.Text = "????";
            // 
            // Data_lblAddress
            // 
            this.Data_lblAddress.AutoSize = true;
            this.Data_lblAddress.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lblAddress.ForeColor = System.Drawing.Color.Black;
            this.Data_lblAddress.Location = new System.Drawing.Point(154, 257);
            this.Data_lblAddress.Name = "Data_lblAddress";
            this.Data_lblAddress.Size = new System.Drawing.Size(58, 42);
            this.Data_lblAddress.TabIndex = 18;
            this.Data_lblAddress.Text = "????";
            // 
            // Data_lblEmail
            // 
            this.Data_lblEmail.AutoSize = true;
            this.Data_lblEmail.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lblEmail.ForeColor = System.Drawing.Color.Black;
            this.Data_lblEmail.Location = new System.Drawing.Point(154, 215);
            this.Data_lblEmail.Name = "Data_lblEmail";
            this.Data_lblEmail.Size = new System.Drawing.Size(58, 42);
            this.Data_lblEmail.TabIndex = 17;
            this.Data_lblEmail.Text = "????";
            // 
            // Data_lblName
            // 
            this.Data_lblName.AutoSize = true;
            this.Data_lblName.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lblName.ForeColor = System.Drawing.Color.Black;
            this.Data_lblName.Location = new System.Drawing.Point(154, 89);
            this.Data_lblName.Name = "Data_lblName";
            this.Data_lblName.Size = new System.Drawing.Size(58, 42);
            this.Data_lblName.TabIndex = 16;
            this.Data_lblName.Text = "????";
            // 
            // Data_lblNationalNo
            // 
            this.Data_lblNationalNo.AutoSize = true;
            this.Data_lblNationalNo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lblNationalNo.ForeColor = System.Drawing.Color.Black;
            this.Data_lblNationalNo.Location = new System.Drawing.Point(154, 131);
            this.Data_lblNationalNo.Name = "Data_lblNationalNo";
            this.Data_lblNationalNo.Size = new System.Drawing.Size(58, 42);
            this.Data_lblNationalNo.TabIndex = 15;
            this.Data_lblNationalNo.Text = "????";
            // 
            // Data_lblID
            // 
            this.Data_lblID.AutoSize = true;
            this.Data_lblID.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lblID.ForeColor = System.Drawing.Color.Black;
            this.Data_lblID.Location = new System.Drawing.Point(154, 47);
            this.Data_lblID.Name = "Data_lblID";
            this.Data_lblID.Size = new System.Drawing.Size(58, 42);
            this.Data_lblID.TabIndex = 14;
            this.Data_lblID.Text = "????";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lblDateOfBirth.Location = new System.Drawing.Point(444, 132);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(163, 44);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(519, 174);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(89, 44);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone:";
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGendor.ForeColor = System.Drawing.Color.Black;
            this.lblGendor.Location = new System.Drawing.Point(6, 173);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(102, 44);
            this.lblGendor.TabIndex = 11;
            this.lblGendor.Text = "Gendor:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(6, 257);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(106, 44);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(497, 210);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(111, 44);
            this.lblCountry.TabIndex = 9;
            this.lblCountry.Text = "Country:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(6, 215);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(83, 44);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(6, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 44);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // lblNationalNo
            // 
            this.lblNationalNo.AutoSize = true;
            this.lblNationalNo.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalNo.ForeColor = System.Drawing.Color.Black;
            this.lblNationalNo.Location = new System.Drawing.Point(6, 131);
            this.lblNationalNo.Name = "lblNationalNo";
            this.lblNationalNo.Size = new System.Drawing.Size(147, 44);
            this.lblNationalNo.TabIndex = 7;
            this.lblNationalNo.Text = "NationalNo:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Urdu Typesetting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(6, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 44);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Person ID:";
            // 
            // Data_lblDateOfBirth
            // 
            this.Data_lblDateOfBirth.Location = new System.Drawing.Point(617, 138);
            this.Data_lblDateOfBirth.Name = "Data_lblDateOfBirth";
            this.Data_lblDateOfBirth.Size = new System.Drawing.Size(266, 33);
            this.Data_lblDateOfBirth.TabIndex = 6;
            // 
            // PersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Person);
            this.Controls.Add(this.lblTitle);
            this.Name = "PersonDetails";
            this.Size = new System.Drawing.Size(1180, 429);
            this.Person.ResumeLayout(false);
            this.Person.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox Person;
        private System.Windows.Forms.DateTimePicker Data_lblDateOfBirth;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGendor;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNationalNo;
        private System.Windows.Forms.Label Data_lblPhone;
        private System.Windows.Forms.Label Data_lblCountry;
        private System.Windows.Forms.Label Data_lblGendor;
        private System.Windows.Forms.Label Data_lblAddress;
        private System.Windows.Forms.Label Data_lblEmail;
        private System.Windows.Forms.Label Data_lblName;
        private System.Windows.Forms.Label Data_lblNationalNo;
        private System.Windows.Forms.Label Data_lblID;
        private System.Windows.Forms.PictureBox PersonImage;
        private System.Windows.Forms.LinkLabel lblEdit;
    }
}
