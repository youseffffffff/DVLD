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
using DVLD_System.Properties;

namespace DVLD_System
{
    public partial class PersonDetails : UserControl
    {
        public PersonDetails()
        {
            InitializeComponent();
        }
        public clsPerson P = null;

        private bool IsObjectFiil(clsPerson P)
        {

            if (P == null) return false;

            Fill();

            return true;
        }
        public bool Load(int PersonID)
        {
            P = clsPerson.Find(PersonID);
            return IsObjectFiil(P);

        }
        public bool Load(string NationalNo)
        {
            P = clsPerson.Find(NationalNo);
            return IsObjectFiil(P);

        }

        private void Fill()
        {
            Data_lblID.Text = P.PersonID.ToString();
            Data_lblName.Text = P.FullName.ToString();
            Data_lblNationalNo.Text = P.NationalNo.ToString();
            Data_lblGendor.Text = (P.Gendor.ToString() == "0") ? "Male" : "Female";
            Data_lblEmail.Text = P.Email.ToString();
            Data_lblAddress.Text = P.Address.ToString();
            Data_lblDateOfBirth.Value = P.DateOfBirth;
            Data_lblPhone.Text = P.Phone.ToString();
            Data_lblCountry.Text = clsPerson.GetCountryNameByCountryID(P.NationalityCountryID);
            PersonImage.Image = (!string.IsNullOrEmpty(P.ImagePath.ToString())) ? Image.FromFile(P.ImagePath.ToString()) : (P.Gendor.ToString() == "0") ? Resources.man : Resources.woman;

        }

        private void lblEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(P != null)
            {
                EditOrAddPerson EditPerson = new EditOrAddPerson(P.PersonID);
                EditPerson.ShowDialog();
                this.Load(P.PersonID);
            }
            else
            {
                EditOrAddPerson EditPerson = new EditOrAddPerson(-1);
                EditPerson.ShowDialog();
            }
        }

   
    }
}
