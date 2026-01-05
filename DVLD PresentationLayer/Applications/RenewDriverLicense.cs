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
    public partial class RenewDriverLicense : Form
    {
        public RenewDriverLicense()
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

        private int _NewLicenseID;

        private clsLicense _NewLicense;


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
        bool CheckIfLicenseDontExpirated()
        {
            if (!CheckIfValidLicense()) return false;

            if (!CheckIfLicenseActive()) return false;

            if (LocalLicense.License.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show("This License Is Not Expirated Yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        bool FillAfterRenew()
        {
            try
            {
                lblRenewedLicenseIDInfo.Text = _NewLicenseID.ToString();
                lblRenewLicenseAppIDInfo.Text = _NewLicense.ApplicationID.ToString();
                lblOldLicenseIDInfo.Text = LocalLicense.License.LicenseID.ToString();
                lblApplicationDateInfo.Text = _NewLicense.Application.ApplicationDate.ToString();
                lblIssueDateInfo.Text = _NewLicense.IssueDate.ToString();
                lblExpirationDateInfo.Text = _NewLicense.ExpirationDate.ToString();
                lblCreatedByInfo.Text = _NewLicense.CreatedByUserID.ToString();
                lblApplicationFeesInfo.Text = _NewLicense.Application.PaidFees.ToString();
                lblLicenseFeesInfo.Text = _NewLicense.PaidFees.ToString();
                lblTotalFeesInfo.Text = (_NewLicense.PaidFees + _NewLicense.Application.PaidFees).ToString();

            }
            catch
            {
                return false;
            }

            return true;
        }
         

        private void btmRenew_Click(object sender, EventArgs e)
        {
            if (!CheckIfValidLicense()) return;

            if (!CheckIfLicenseActive()) return;

            if (!CheckIfLicenseDontExpirated()) return;


            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            clsLicense NewLicense =
                LocalLicense.License.RenewLicense(txtNotesInfo.Text.Trim(),
                clsCurrentUser.User.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            _NewLicense = NewLicense;
            _NewLicenseID = NewLicense.LicenseID;


            if (FillAfterRenew())
            {
                MessageBox.Show("Licensed Renewed Successfully with ID = " + _NewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LocalLicense.FilterEnabled = false;
                btnRenewLicense.Enabled = false;
                lblShowLicenseDetails.Enabled = true;

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
            if (_NewLicense == null) return;

            ShowLicenseDetails showLicenseDetails = new ShowLicenseDetails(_NewLicense.LicenseID);

            showLicenseDetails.ShowDialog();
        }


    }
}
