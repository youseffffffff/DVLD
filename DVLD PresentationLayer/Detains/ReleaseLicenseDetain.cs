using System;
using System.Drawing;
using System.Windows.Forms;
using DVLD_Business_Layer;
using DVLD_System.Licenses;

namespace DVLD_System.Detains
{
    public partial class ReleaseLicenseDetain : Form
    {
        private int _SelectedLicenseID = -1;

        private int _AppID = -1;
        private clsApplication _App
        {
            get
            {
                return clsApplication.Find(_AppID);
            }
        }



        public ReleaseLicenseDetain()
        {
            InitializeComponent();

            this.Size = new Size(900, 600);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public ReleaseLicenseDetain(int LicenseID)
        {
            InitializeComponent();



            _SelectedLicenseID = LicenseID;

            LocalLicense.Load(_SelectedLicenseID);
            LocalLicense.FilterEnabled = false;



            this.Size = new Size(900, 600);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;
        }
      

        private void ReleaseLicenseDetain_Load(object sender, EventArgs e)
        {


        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!CheckIfValidLicense()) return;


            ShowLicenseHistory showLicenseHistory = new ShowLicenseHistory(LocalLicense.License.Application.PersonID);

            showLicenseHistory.ShowDialog();
        }

        private void lblShowLicenseDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!CheckIfValidLicense()) return;

            ShowLicenseDetails showLicenseDetails = new ShowLicenseDetails(LocalLicense.License.LicenseID);

            showLicenseDetails.ShowDialog();
        }
        bool FillBeforeRelease(clsDetainedLicense NewDetain)
        {
            try
            {

                lblDetainIDInfo.Text = NewDetain.DetainID.ToString();
                lblLicenseIDInfo.Text = NewDetain.LicenseID.ToString();
                lblDetainDateInfo.Text = NewDetain.DetainDate.ToString();
                txtFineFeesInfo.Text = NewDetain.FineFees.ToString();
            }
            catch
            {
                return false;
            }

            return true;
        }
        bool FillAfterRelease(clsDetainedLicense NewDetain)
        {
            try
            {
                lblDetainIDInfo.Text = NewDetain.DetainID.ToString();
                lblLicenseIDInfo.Text = NewDetain.LicenseID.ToString();
                lblDetainDateInfo.Text = NewDetain.DetainDate.ToString();
                lblCreatedByInfo.Text = NewDetain.CreatedByUserID.ToString();
                txtFineFeesInfo.Text = NewDetain.FineFees.ToString();

                lblApplicationFeesInfo.Text = _App.PaidFees.ToString();
                lblTotalFeesInfo.Text = (NewDetain.FineFees + _App.PaidFees).ToString();

            }
            catch
            {
                return false;
            }

            return true;
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
        bool CheckIfLicenseDetain()
        {
            if (!clsLicense.IsDetain(LocalLicense.License.LicenseID))
            {
                MessageBox.Show("This License Is Don't Detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void btmRelease_Click(object sender, EventArgs e)
        {
            if (!CheckIfValidLicense()) return;

            if (!CheckIfLicenseActive()) return;

            if (!CheckIfLicenseDetain()) return;

            clsDetainedLicense NewDetain = clsDetainedLicense.FindByLicenseID(LocalLicense.License.LicenseID);

            if (!FillBeforeRelease(NewDetain)) return;

            if (MessageBox.Show("Release ?.", "Found", MessageBoxButtons.OK) == DialogResult.OK)
            {
                if (!LocalLicense.License.ReleaseDetainedLicense(clsCurrentUser.User.UserID, ref _AppID)) return;
            }
            if (FillAfterRelease(NewDetain))
            {
                MessageBox.Show("Done Detain Successfully.", "Success", MessageBoxButtons.OK);
                btmRelease.Enabled = false;
                lblShowLicenseDetails.Enabled = true;
                LocalLicense.FilterEnabled = false;
                grbReleaseAppInfo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Feiled, Try Again.", "Success", MessageBoxButtons.OK);
            }
        }
    }
}
