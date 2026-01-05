namespace DVLD_System
{
    partial class EditOrAddPerson
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
            this.Close = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Card = new System.Windows.Forms.GroupBox();
            this.LinkLBL_Remove = new System.Windows.Forms.LinkLabel();
            this.EditImage = new System.Windows.Forms.LinkLabel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.cbGendor = new System.Windows.Forms.ComboBox();
            this.NationalNo = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.lb_ThirdName = new System.Windows.Forms.Label();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.lb_LastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_SecondName = new System.Windows.Forms.Label();
            this.lb_Gendor = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lb_DateOfBirth = new System.Windows.Forms.Label();
            this.dDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lb_Country = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.Icon = new System.Windows.Forms.Label();
            this.LoadImage = new System.Windows.Forms.SaveFileDialog();
            this.PersonImage = new System.Windows.Forms.PictureBox();
            this.Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Gray;
            this.Close.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Close.Location = new System.Drawing.Point(249, 736);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(127, 57);
            this.Close.TabIndex = 35;
            this.Close.Tag = "";
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.DimGray;
            this.Save.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Save.Location = new System.Drawing.Point(450, 736);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(119, 57);
            this.Save.TabIndex = 34;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Card
            // 
            this.Card.Controls.Add(this.LinkLBL_Remove);
            this.Card.Controls.Add(this.EditImage);
            this.Card.Controls.Add(this.PersonImage);
            this.Card.Controls.Add(this.Save);
            this.Card.Controls.Add(this.Close);
            this.Card.Controls.Add(this.txtEmail);
            this.Card.Controls.Add(this.lb_Email);
            this.Card.Controls.Add(this.cbGendor);
            this.Card.Controls.Add(this.NationalNo);
            this.Card.Controls.Add(this.txtNationalNo);
            this.Card.Controls.Add(this.lb_ThirdName);
            this.Card.Controls.Add(this.txtThirdName);
            this.Card.Controls.Add(this.lb_LastName);
            this.Card.Controls.Add(this.txtLastName);
            this.Card.Controls.Add(this.lb_FirstName);
            this.Card.Controls.Add(this.txtFirstName);
            this.Card.Controls.Add(this.lb_ID);
            this.Card.Controls.Add(this.lb_SecondName);
            this.Card.Controls.Add(this.lb_Gendor);
            this.Card.Controls.Add(this.cbCountry);
            this.Card.Controls.Add(this.lb_DateOfBirth);
            this.Card.Controls.Add(this.dDateOfBirth);
            this.Card.Controls.Add(this.txtPhone);
            this.Card.Controls.Add(this.lb_Country);
            this.Card.Controls.Add(this.txtAddress);
            this.Card.Controls.Add(this.txtSecondName);
            this.Card.Controls.Add(this.lb_Address);
            this.Card.Controls.Add(this.txtID);
            this.Card.Controls.Add(this.lb_Phone);
            this.Card.Font = new System.Drawing.Font("Stencil", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.Location = new System.Drawing.Point(34, 121);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(913, 916);
            this.Card.TabIndex = 33;
            this.Card.TabStop = false;
            this.Card.Text = "Person Informations";
            // 
            // LinkLBL_Remove
            // 
            this.LinkLBL_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkLBL_Remove.AutoSize = true;
            this.LinkLBL_Remove.Enabled = false;
            this.LinkLBL_Remove.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLBL_Remove.Location = new System.Drawing.Point(724, 415);
            this.LinkLBL_Remove.Name = "LinkLBL_Remove";
            this.LinkLBL_Remove.Size = new System.Drawing.Size(93, 25);
            this.LinkLBL_Remove.TabIndex = 39;
            this.LinkLBL_Remove.TabStop = true;
            this.LinkLBL_Remove.Text = "Remove";
            this.LinkLBL_Remove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLBL_Remove_LinkClicked);
            // 
            // EditImage
            // 
            this.EditImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditImage.AutoSize = true;
            this.EditImage.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditImage.Location = new System.Drawing.Point(573, 415);
            this.EditImage.Name = "EditImage";
            this.EditImage.Size = new System.Drawing.Size(125, 25);
            this.EditImage.TabIndex = 38;
            this.EditImage.TabStop = true;
            this.EditImage.Text = "Edit Image";
            this.EditImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EditImage_LinkClicked);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(274, 597);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 39);
            this.txtEmail.TabIndex = 36;
            // 
            // lb_Email
            // 
            this.lb_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(34, 604);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(87, 31);
            this.lb_Email.TabIndex = 35;
            this.lb_Email.Text = "Email";
            // 
            // cbGendor
            // 
            this.cbGendor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGendor.FormattingEnabled = true;
            this.cbGendor.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGendor.Location = new System.Drawing.Point(274, 431);
            this.cbGendor.Name = "cbGendor";
            this.cbGendor.Size = new System.Drawing.Size(200, 40);
            this.cbGendor.TabIndex = 34;
            this.cbGendor.SelectedIndexChanged += new System.EventHandler(this.cbGendor_SelectedIndexChanged);
            // 
            // NationalNo
            // 
            this.NationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NationalNo.AutoSize = true;
            this.NationalNo.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalNo.Location = new System.Drawing.Point(34, 109);
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.Size = new System.Drawing.Size(149, 31);
            this.NationalNo.TabIndex = 33;
            this.NationalNo.Text = "NationalNo";
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNationalNo.Location = new System.Drawing.Point(274, 101);
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(200, 39);
            this.txtNationalNo.TabIndex = 32;
            // 
            // lb_ThirdName
            // 
            this.lb_ThirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ThirdName.AutoSize = true;
            this.lb_ThirdName.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ThirdName.Location = new System.Drawing.Point(34, 274);
            this.lb_ThirdName.Name = "lb_ThirdName";
            this.lb_ThirdName.Size = new System.Drawing.Size(157, 31);
            this.lb_ThirdName.TabIndex = 29;
            this.lb_ThirdName.Text = "Third Name";
            // 
            // txtThirdName
            // 
            this.txtThirdName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThirdName.Location = new System.Drawing.Point(274, 266);
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(200, 39);
            this.txtThirdName.TabIndex = 28;
            // 
            // lb_LastName
            // 
            this.lb_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_LastName.AutoSize = true;
            this.lb_LastName.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LastName.Location = new System.Drawing.Point(34, 329);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(141, 31);
            this.lb_LastName.TabIndex = 30;
            this.lb_LastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(274, 321);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 39);
            this.txtLastName.TabIndex = 31;
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FirstName.Location = new System.Drawing.Point(34, 164);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(146, 31);
            this.lb_FirstName.TabIndex = 3;
            this.lb_FirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(274, 156);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 39);
            this.txtFirstName.TabIndex = 0;
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.Location = new System.Drawing.Point(34, 54);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(47, 31);
            this.lb_ID.TabIndex = 1;
            this.lb_ID.Text = "ID";
            // 
            // lb_SecondName
            // 
            this.lb_SecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SecondName.AutoSize = true;
            this.lb_SecondName.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SecondName.Location = new System.Drawing.Point(34, 219);
            this.lb_SecondName.Name = "lb_SecondName";
            this.lb_SecondName.Size = new System.Drawing.Size(170, 31);
            this.lb_SecondName.TabIndex = 3;
            this.lb_SecondName.Text = "Second Name";
            // 
            // lb_Gendor
            // 
            this.lb_Gendor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Gendor.AutoSize = true;
            this.lb_Gendor.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gendor.Location = new System.Drawing.Point(34, 439);
            this.lb_Gendor.Name = "lb_Gendor";
            this.lb_Gendor.Size = new System.Drawing.Size(100, 31);
            this.lb_Gendor.TabIndex = 5;
            this.lb_Gendor.Text = "Gendor";
            // 
            // cbCountry
            // 
            this.cbCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(274, 652);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(200, 40);
            this.cbCountry.TabIndex = 24;
            // 
            // lb_DateOfBirth
            // 
            this.lb_DateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_DateOfBirth.AutoSize = true;
            this.lb_DateOfBirth.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DateOfBirth.Location = new System.Drawing.Point(34, 384);
            this.lb_DateOfBirth.Name = "lb_DateOfBirth";
            this.lb_DateOfBirth.Size = new System.Drawing.Size(179, 31);
            this.lb_DateOfBirth.TabIndex = 6;
            this.lb_DateOfBirth.Text = "Date Of Birth";
            // 
            // dDateOfBirth
            // 
            this.dDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dDateOfBirth.Location = new System.Drawing.Point(274, 376);
            this.dDateOfBirth.MaxDate = new System.DateTime(2077, 5, 5, 0, 0, 0, 0);
            this.dDateOfBirth.Name = "dDateOfBirth";
            this.dDateOfBirth.Size = new System.Drawing.Size(200, 39);
            this.dDateOfBirth.TabIndex = 23;
            this.dDateOfBirth.Value = new System.DateTime(2006, 3, 7, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(274, 542);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 39);
            this.txtPhone.TabIndex = 21;
            // 
            // lb_Country
            // 
            this.lb_Country.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Country.AutoSize = true;
            this.lb_Country.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Country.Location = new System.Drawing.Point(34, 659);
            this.lb_Country.Name = "lb_Country";
            this.lb_Country.Size = new System.Drawing.Size(107, 31);
            this.lb_Country.TabIndex = 8;
            this.lb_Country.Text = "Country";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(274, 487);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 39);
            this.txtAddress.TabIndex = 20;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecondName.Location = new System.Drawing.Point(274, 211);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(200, 39);
            this.txtSecondName.TabIndex = 14;
            // 
            // lb_Address
            // 
            this.lb_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(34, 494);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(105, 31);
            this.lb_Address.TabIndex = 11;
            this.lb_Address.Text = "Address";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(274, 54);
            this.txtID.Name = "txtID";
            this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtID.Size = new System.Drawing.Size(62, 31);
            this.txtID.TabIndex = 13;
            this.txtID.Text = "????";
            // 
            // lb_Phone
            // 
            this.lb_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Font = new System.Drawing.Font("Modern No. 20", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.Location = new System.Drawing.Point(34, 549);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(90, 31);
            this.lb_Phone.TabIndex = 12;
            this.lb_Phone.Text = "Phone";
            // 
            // Icon
            // 
            this.Icon.AutoSize = true;
            this.Icon.Font = new System.Drawing.Font("Playbill", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Icon.Location = new System.Drawing.Point(361, 32);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(110, 70);
            this.Icon.TabIndex = 32;
            this.Icon.Text = "????";
            // 
            // PersonImage
            // 
            this.PersonImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PersonImage.Image = global::DVLD_System.Properties.Resources.woman;
            this.PersonImage.Location = new System.Drawing.Point(600, 175);
            this.PersonImage.Name = "PersonImage";
            this.PersonImage.Size = new System.Drawing.Size(204, 226);
            this.PersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PersonImage.TabIndex = 37;
            this.PersonImage.TabStop = false;
            // 
            // EditOrAddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 1041);
            this.Controls.Add(this.Card);
            this.Controls.Add(this.Icon);
            this.Name = "EditOrAddPerson";
            this.Text = "EditOrAddPerson";
            this.Load += new System.EventHandler(this.EditOrAddPerson_Load);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox Card;
        private System.Windows.Forms.Label lb_ThirdName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_SecondName;
        private System.Windows.Forms.Label lb_Gendor;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lb_DateOfBirth;
        private System.Windows.Forms.DateTimePicker dDateOfBirth;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lb_Country;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label Icon;
        private System.Windows.Forms.ComboBox cbGendor;
        private System.Windows.Forms.Label NationalNo;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.LinkLabel EditImage;
        private System.Windows.Forms.PictureBox PersonImage;
        private System.Windows.Forms.SaveFileDialog LoadImage;
        private System.Windows.Forms.LinkLabel LinkLBL_Remove;
    }
}