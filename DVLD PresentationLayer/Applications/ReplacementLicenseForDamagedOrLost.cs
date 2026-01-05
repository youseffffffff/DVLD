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
using DVLD_System.Licenses;

namespace DVLD_System.Applications
{
    public partial class ReplacementLicenseForDamagedOrLost : Form
    {
        public ReplacementLicenseForDamagedOrLost()
        {

            InitializeComponent();

            this.Size = new Size(900, 700);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        public clsLicense NewLicense;


        int AppTypeID()
        {
            return (DamagedChoise.Checked) ? (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense : (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
        }

        bool CheckIfLicenseActive()
        {
            if (!LocalLicense.License.IsActive)
            {
                MessageBox.Show("This License Is UnActive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        bool CheckIfValidLicense()
        {
            if (LocalLicense.License == null)
            {
                MessageBox.Show("Please select a local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }


  
        bool FillAfterReplacement()
        {
            try
            {
                lblRenewedLicenseIDInfo.Text = NewLicense.LicenseID.ToString();
                lblRenewLicenseAppIDInfo.Text = NewLicense.ApplicationID.ToString();
                lblOldLicenseIDInfo.Text = LocalLicense.License.LicenseID.ToString();
                lblApplicationDateInfo.Text = DateTime.Now.ToString();
                lblIssueDateInfo.Text = DateTime.Now.ToString();
                lblExpirationDateinfo.Text = DateTime.Now.AddYears((int)clsLicenseClass.Find(LocalLicense.License.LicenseClassID).DefaultValiDityLength).ToString();
                lblCreatedByInfo.Text = clsCurrentUser.User.FirstName.ToString();
                lblApplicationFeesInfo.Text = clsApplicationType.Find(AppTypeID()).ApplicationFees.ToString();
                lblLicenseFeesInfo.Text = LocalLicense.License.PaidFees.ToString();
                lblTotalFeesInfo.Text = (clsApplicationType.Find(AppTypeID()).ApplicationFees + LocalLicense.License.PaidFees).ToString();
                
            }
            catch
            {
                return false;
            }

            return true;
        }

        bool IfDontClickTypeApp()
        {
            if (!DamagedChoise.Checked && !LostChoise.Checked)
            {
                MessageBox.Show("Please Choose The Type Of Replacement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btmReplace_Click(object sender, EventArgs e)
        {
            if (!IfDontClickTypeApp()) return;

            if (!CheckIfValidLicense()) return;

            if (!CheckIfLicenseActive()) return;

            NewLicense = LocalLicense.License.Replace((clsLicense.enIssueReason)AppTypeID(), clsCurrentUser.User.UserID);

            if (NewLicense != null)
            {
                if (FillAfterReplacement())
                {

                    MessageBox.Show("Done Replacement Successfully.", "Success", MessageBoxButtons.OK);


                    LocalLicense.Enabled = false;
                    grbApplicationNewLicenseInfo.Enabled = false;

                    lblShowLicenseDetails.Enabled = true;
                }
            }
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!CheckIfValidLicense()) return;


            ShowLicenseHistory showLicenseHistory = new ShowLicenseHistory(LocalLicense.License.Application.PersonID);

            showLicenseHistory.ShowDialog();
        }

        private void lblShowLicenseDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (NewLicense == null) return;

            ShowLicenseDetails showLicenseDetails = new ShowLicenseDetails(NewLicense.LicenseID);

            showLicenseDetails.ShowDialog();
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DamagedChoise_CheckedChanged(object sender, EventArgs e)
        {

            lblTitle.Text = "Replacement for Damaged License";
            this.Text = lblTitle.Text;
            lblApplicationFeesInfo.Text = clsApplicationType.Find(AppTypeID()).ApplicationFees.ToString();

        }

        private void LostChoise_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement for Lost License";
            this.Text = lblTitle.Text;
            lblApplicationFeesInfo.Text = clsApplicationType.Find(AppTypeID()).ApplicationFees.ToString();

        }

        private void ReplacementLicenseForDamagedOrLost_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtNotesInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
