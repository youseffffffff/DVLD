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

namespace DVLD_System.Licenses
{
    public partial class LicenseDetails : UserControl
    {
        public LicenseDetails()
        {
            InitializeComponent();
        }
        public clsLicense L = null;

        private bool IsObjectFill(clsLicense L)
        {

            if (L == null) return false;

            Fill();

            return true;
        }
        public bool Load(int LicenseID)
        {
            L = clsLicense.FindByLicenseID(LicenseID);
            return IsObjectFill(L);

        }

        private void Fill()
        {
            clsPerson P = clsPerson.Find(clsApplication.Find(L.ApplicationID).PersonID);

            lblClassInfo.Text = clsLicenseClass.Find(L.LicenseClassID).ClassName.ToString();
            lblNameInfo.Text = P.FullName.ToString();
            lblNationalNoInfo.Text = P.NationalNo.ToString();
            lblGendorInfo.Text = (P.Gendor.ToString() == "0") ? "Male" : "Female";
            lblLicenseIDInfo.Text = L.LicenseID.ToString();
            lblIssueDateInfo.Text = L.IssueDate.ToString();
            lblDateOfBirthInfo.Text = P.DateOfBirth.ToString();
            lblNotesInfo.Text = L.Notes.ToString();
            lblIssueReasonInfo.Text = L.IssueReason.ToString();
            PersonImage.Image = (P.ImagePath.ToString() != "") ? Image.FromFile(P.ImagePath.ToString()) : Resources.man;
            lblIsActiveInfo.Text = (L.IsActive) ? "Yes" : "No";
            lblIsDetainedInfo.Text = (clsLicense.IsDetain(L.LicenseID)) ? "Yes" : "No";
            lblDriverIDInfo.Text = L.DriverID.ToString();
            lblExiprationDateInfo.Text = L.ExpirationDate.ToString();


        }

        private void lblIsActiveInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblShowPersonDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonDetails SPD = new ShowPersonDetails(clsApplication.Find(L.ApplicationID).PersonID);
            SPD.ShowDialog();
        }
    }
}
