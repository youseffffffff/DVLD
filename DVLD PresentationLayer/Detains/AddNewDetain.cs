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

namespace DVLD_System.Detains
{
    public partial class AddNewDetain : Form
    {
        public AddNewDetain()
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

        private void AddNewDetain_Load(object sender, EventArgs e)
        {

        }







        bool CheckIfLicenseUnActive()
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
            if (clsLicense.IsDetain(LocalLicense.License.LicenseID))
            {
                MessageBox.Show("This License Is Already Detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        bool CheckIfNotValidLicense()
        {
            if (LocalLicense.License == null)
            {
                MessageBox.Show("Please select a local license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }


        bool FillAfterDetain(clsDetainedLicense NewDetain)
        {
            try
            {
                lblDetainIDInfo.Text = NewDetain.DetainID.ToString();
                lblLicenseIDInfo.Text = NewDetain.LicenseID.ToString();
                lblDetainDateInfo.Text = NewDetain.DetainDate.ToString();
                lblCreatedByInfo.Text = NewDetain.CreatedByUserID.ToString();
                txtFineFeesInfo.Text = NewDetain.FineFees.ToString();
            }
            catch
            {
                return false;
            }

            return true;
        }
        bool IsDontEnterFineFees()
        {
            if (string.IsNullOrEmpty(txtFineFeesInfo.Text))
            {
                MessageBox.Show("Please Enter The Fine Fees.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btmDetain_Click(object sender, EventArgs e)
        {
            if (!CheckIfNotValidLicense()) return;

            if (!CheckIfLicenseUnActive()) return;

            if (!CheckIfLicenseDetain()) return;

            if (!IsDontEnterFineFees()) return;


            int NewDetainID = LocalLicense.License.Detain(Convert.ToDouble(txtFineFeesInfo.Text), clsCurrentUser.User.UserID);

        
            clsDetainedLicense NewDetain = clsDetainedLicense.FindByDetainID(NewDetainID);

            if (NewDetain == null)
            {
                MessageBox.Show("Feiled, Try Again.", "Success", MessageBoxButtons.OK);
                return;
            }
            if (FillAfterDetain(NewDetain))
            {

                MessageBox.Show("Done Detain Successfully.", "Success", MessageBoxButtons.OK);
                btmDetain.Enabled = false;
                lblShowLicenseDetails.Enabled = true;
                grbDetainInfo.Enabled = false;
                LocalLicense.FilterEnabled = false;
            }
            else
            {
                MessageBox.Show("Feiled, Try Again.", "Success", MessageBoxButtons.OK);
                return;
            }
        }

        private void lblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!CheckIfNotValidLicense()) return;


            ShowLicenseHistory showLicenseHistory = new ShowLicenseHistory(LocalLicense.License.Application.PersonID);

            showLicenseHistory.ShowDialog();
        }

        private void lblShowLicenseDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!CheckIfNotValidLicense()) return;

            ShowLicenseDetails showLicenseDetails = new ShowLicenseDetails(LocalLicense.License.LicenseID);

            showLicenseDetails.ShowDialog();
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                return; 
            }
        }
    }
}
