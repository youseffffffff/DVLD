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
    public partial class AddNewInternationalLicense : Form
    {
        public clsInternationalLicense InternationalLicense;
        public clsApplication App;
        public AddNewInternationalLicense()
        {
            InternationalLicense = new clsInternationalLicense();
            App = new clsApplication();


            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;



            InitializeComponent();
        }

        private void AddNewInternationalLicense_Load(object sender, EventArgs e)
        {

        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool CheckIfValidForm()
        {
            if (LocalLicense.License == null)
            {
                MessageBox.Show("Please select a local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        bool MakeNewInternationalLicense()
        {

            InternationalLicense.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInternationalLicense;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = (int)clsApplication.enApplicationStatus.Completed;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = InternationalLicense.ApplicationType.ApplicationFees;
            InternationalLicense.PersonID = LocalLicense.License.Application.PersonID;
            InternationalLicense.CreatedByUserID = clsCurrentUser.User.UserID;


            InternationalLicense.IssuedUsingLocalLicenseID = LocalLicense.License.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.IsActive = true;
            InternationalLicense.ExpirationDate = InternationalLicense.IssueDate.AddYears(1);
            InternationalLicense.DriverID = LocalLicense.License.DriverID;
            InternationalLicense.CreatedByUserID = clsCurrentUser.User.UserID;

            return InternationalLicense.Save();
        }

        bool IsLicensesClassOrdinary()
        {
            if (LocalLicense.License.LicenseClassID != 3)
            {                   
                MessageBox.Show("Cannot Issue Only Ordinary License Class", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                return false;                
            }
            return true;
        }

        private void btmSave_Click(object sender, EventArgs e)
        {
            if (!CheckIfValidForm()) return;

            if (!IsLicensesClassOrdinary()) return;


            if (!MakeNewInternationalLicense()) return;


            if (internationalApplicationDetails.Load(InternationalLicense.InternationalLicenseID))
            {
                lblShowLicenseDetails.Enabled = true;
                btmSave.Enabled = false;
                LocalLicense.FilterEnabled = false;

                MessageBox.Show("International License Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to load International License details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LocalLicense_Load(object sender, EventArgs e)
        {

        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!CheckIfValidForm()) return;

            App = clsApplication.Find(LocalLicense.License.ApplicationID);

            if (App == null) return;       

            ShowLicenseHistory showLicenseHistory = new ShowLicenseHistory(App.PersonID);

            showLicenseHistory.ShowDialog();

        }

        private void lblShowLicenseDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (InternationalLicense == null)
            {
                return;
            }

            ShowInternationalLicenseDetails showInternationalLicenseDetails = new ShowInternationalLicenseDetails(InternationalLicense.InternationalLicenseID);
            showInternationalLicenseDetails.ShowDialog();
        }
    }
}
