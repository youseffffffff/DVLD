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

namespace DVLD_System.Licenses
{
    public partial class IssueLicense : Form
    {
        private clsLocalDrivingLicenseApplication LocalApp;
        private int LocalAppID;
        public IssueLicense(int LocalAppID)
        {
            this.LocalAppID = LocalAppID;

            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;


            InitializeComponent();
        }

        private void IssueLicense_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();

            this.LocalApp = clsLocalDrivingLicenseApplication.Find(LocalAppID);




            if (LocalApp == null)
            {
                MessageBox.Show("No Applicaiton with ID=" + LocalApp.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            if (!LocalApp.IsPassedAllTests())
            {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = LocalApp.GetActiveLicenseID();

            if (LicenseID != -1)
            {
                MessageBox.Show("Person already has License before with License ID=" + LicenseID.ToString(), "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }

            appDetails1.Load(LocalApp.LocalAppID);
            
        }

        bool IfDriverInSystem()
        {

            if (!clsDriver.IsPersonDriver(LocalApp.PersonID))
            {
                clsDriver Driver = new clsDriver();
                Driver.PersonID = LocalApp.PersonID;
                Driver.CreatedDate = DateTime.Now;
                Driver.CreatedByUserID = clsCurrentUser.User.UserID;

                if(Driver.Save())
                {
                    return false;
                }
            }

            return true;
        }

        private void btmSave_Click(object sender, EventArgs e)
        {
            int LicenseID = LocalApp.IssueLicenseForTheFirtTime(txtNotes.Text.Trim(), clsCurrentUser.User.UserID);

            if (LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID.ToString(),
                    "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("License Was not Issued ! ",
                 "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
