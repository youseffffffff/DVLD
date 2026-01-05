using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;
using System.Resources;
using DVLD_System.Properties;

namespace DVLD_System
{
    public partial class EditOrAddPerson : Form
    {
        public EditOrAddPerson(int ID)
        {
            InitializeComponent();


            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;


            SetCountries(cbCountry);

            P = clsPerson.Find(ID);

            if (P == null)
            {
                Mode = enMode.AddNew;
                P = new clsPerson();
            }
            else
                Mode = enMode.Update;
        }

        clsPerson P = new clsPerson();

        private enum enMode { AddNew = 0, Update = 1 }

        enMode Mode;




        bool IsValidForm()
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text))
            {
                MessageBox.Show("Please enter NationalNo", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter First Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtSecondName.Text))
            {
                MessageBox.Show("Please enter Second Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtThirdName.Text))
            {
                MessageBox.Show("Please enter ThirdName", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter Last Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!clsPerson.IsValidEmail(txtEmail.Text))
            
            {
                MessageBox.Show("Please enter a valid Email", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please enter Phone Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter An Address", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbCountry.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Country", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbGendor.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Gendor", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (PersonImage.Image == null) PersonImage.Image = Resources.man;

            return true;
        }

        private void SetCountries(ComboBox c)
        {
            c.Items.Clear();

            DataTable Countries = clsPerson.GetAllCountries();

            foreach (DataRow Row in Countries.Rows)
            {
                c.Items.Add(Row["CountryName"].ToString());
            }
        }
        private void SaveDataToPerson(clsPerson P)
        {
            P.NationalNo = txtNationalNo.Text;

            P.FirstName = txtFirstName.Text;
            P.SecondName = txtSecondName.Text;
            P.ThirdName = txtThirdName.Text;
            P.LastName = txtLastName.Text;
            P.DateOfBirth = dDateOfBirth.Value;
            P.Gendor = (cbGendor.Text == "Male") ? 0 : 1;

            P.Address = txtAddress.Text;
            P.Phone = txtPhone.Text;

            P.Email = txtEmail.Text;
            P.NationalityCountryID = clsPerson.GetCountryIDByCountryName(cbCountry.Text);
            P.ImagePath = PersonImage.Tag as string;

        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (!IsValidForm()) return;

            SaveDataToPerson(P);
            if(!P.Save())
            {
                MessageBox.Show("Fieled To Save Informatins", "Fieled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (Mode)
            {
                case enMode.AddNew:
                    MessageBox.Show("Person Login Successfuly", "Done", MessageBoxButtons.OK);
                    txtID.Text = P.PersonID.ToString();
                    break;

                case enMode.Update:
                    MessageBox.Show("Person Edit Successfuly", "Done", MessageBoxButtons.OK);

                    break;
            }

        }
        private void FillPersonInfo()
        {
            txtID.Text = P.PersonID.ToString();
            txtNationalNo.Text = P.NationalNo.ToString();
            txtFirstName.Text = P.FirstName.ToString();
            txtSecondName.Text = P.SecondName.ToString();
            txtThirdName.Text = P.ThirdName.ToString();
            txtLastName.Text = P.LastName.ToString();
            cbGendor.SelectedIndex = cbGendor.FindString( (P.Gendor == 0) ? "Male" : "Female");
            cbCountry.Text = clsPerson.GetCountryNameByCountryID(P.NationalityCountryID);
            dDateOfBirth.Value = P.DateOfBirth;
            txtAddress.Text = P.Address.ToString();
            txtPhone.Text = P.Phone.ToString();
            txtEmail.Text = P.Email.ToString();
            if(!string.IsNullOrEmpty(P.ImagePath))
            {
                PersonImage.Image = Image.FromFile(P.ImagePath);
                PersonImage.Tag = P.ImagePath;
                LinkLBL_Remove.Enabled = true;
            }

            else
            {
                PersonImage.Image = Resources.man;
                PersonImage.Tag = string.Empty;
                LinkLBL_Remove.Enabled = false;

            }


        }
        private void SetEmptyForm()
        {
            txtID.Text = "????";
            txtNationalNo.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtSecondName.Text = string.Empty;
            txtThirdName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cbGendor.Text = string.Empty;
            cbCountry.Text = string.Empty;
            dDateOfBirth.Value = DateTime.Now;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            PersonImage.Image = Resources.man;
            PersonImage.Tag = string.Empty;
            LinkLBL_Remove.Enabled = false;
        }

        private void SetIconName(string Icomname)
        {
            Icon.Text = Icomname;
        }
        private void EditOrAddPerson_Load(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    SetIconName("Add New Person");

                    SetEmptyForm();

                    break;

                case enMode.Update:

                    SetIconName("Update Person");

                    FillPersonInfo();

                    break;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LoadImage.ShowDialog() == DialogResult.OK)
            {                
                LinkLBL_Remove.Enabled = true;                
                string selectedPath = LoadImage.FileName;                
                PersonImage.Image = Image.FromFile(selectedPath);
                PersonImage.Tag = selectedPath;
                

            }
        }

        private void LinkLBL_Remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonImage.Image = Resources.man;
            PersonImage.Tag = string.Empty;
            LinkLBL_Remove.Enabled = false;
        }

        private void cbGendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(PersonImage.Tag as string))
            {
                PersonImage.Image = (cbGendor.Text == "Female") ? Resources.woman : Resources.man;
            }
        }
    }
}
