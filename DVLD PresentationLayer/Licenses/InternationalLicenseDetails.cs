using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;
using DVLD_Business_Layer;


namespace DVLD_System.Licenses
{
    public partial class InternationalLicenseDetails : UserControl
    {
        public clsInternationalLicense IntLicense;
        public clsApplication App;
        public InternationalLicenseDetails()
        {
            InitializeComponent();
        }
        bool Fill()
        {

            try
            {
                lblNameInfo.Text = App.Person.FullName.ToString();
                lblInternationalLicenseIDInfo.Text = IntLicense.InternationalLicenseID.ToString();
                lblLicenseIDInfo.Text = IntLicense.IssuedUsingLocalLicenseID.ToString();
                lblNameInfo.Text = App.Person.NationalNo.ToString();
                lblGendorInfo.Text = (App.Person.Gendor.ToString() == "0") ? "Male" : "Female";
                lblIssueDateInfo.Text = IntLicense.IssueDate.ToString("dd/MM/yyyy");
                lblApplicationIDInfo.Text = IntLicense.AppID.ToString();
                lblIsActiveInfo.Text = IntLicense.IsActive == true ? "Yes" : "No";
                lblDateOfBirthInfo.Text = App.Person.DateOfBirth.ToString("dd/MM/yyyy");
                lblDriverIDInfo.Text = IntLicense.DriverID.ToString();
                lblExpirationDateInfo.Text = IntLicense.ExpirationDate.ToString("dd/MM/yyyy");
                PersonImage.Image = Image.FromFile(App.Person.ImagePath);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public bool Load(int InternationalLicenseID)
        {
           
            if ((this.IntLicense = clsInternationalLicense.Find(InternationalLicenseID)) != null)
            {
                if ((this.App = clsApplication.Find(IntLicense.AppID)) != null)
                {
                    return Fill();
                }
            }


            
            return false;
        }
    }
}
