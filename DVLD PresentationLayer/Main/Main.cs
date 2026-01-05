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
using DVLD_System.Applications;
using DVLD_System.Detains;
using DVLD_System.Licenses;


namespace DVLD_System
{
    public partial class Main : Form
    {


        public int CurrentUserID;
        public Main(int UserID)
        {
            this.WindowState = FormWindowState.Maximized;

            CurrentUserID = UserID; 

            InitializeComponent();
        }






        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScreen ManagePeople = new ManageScreen(clsPerson.GetAllPeople());

            ManagePeople.MdiParent = this;

            ManagePeople.Show();
        }


                
        private void managePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScreen ManageUsers = new ManageScreen(clsUser.GetAllUsers());

            ManageUsers.MdiParent = this;

            ManageUsers.Show();
        }

        private void showCurrentUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserDetails showUserDetails = new ShowUserDetails(CurrentUserID);

            showUserDetails.MdiParent = this;
            showUserDetails.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword managePeople = new ChangePassword(CurrentUserID);

            managePeople.MdiParent = this;
            managePeople.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void apllicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScreen ManageApplicationTypes = new ManageScreen(clsApplicationType.GetAllApplicationTypes());

            ManageApplicationTypes.MdiParent = this;

            ManageApplicationTypes.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageScreen ManageTestTypes = new ManageScreen(clsTestType.GetAllTestTypes());

            ManageTestTypes.MdiParent = this;

            ManageTestTypes.Show();

        }

        private void localLicensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScreen ManageLocalDrivingLicenseApplications = new ManageScreen(clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications());

            ManageLocalDrivingLicenseApplications.MdiParent = this;

            ManageLocalDrivingLicenseApplications.Show();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewInternationalLicense addNewInternationalLicense = new AddNewInternationalLicense();
            addNewInternationalLicense.MdiParent = this;
            addNewInternationalLicense.Show();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewLocalDrivingLicenseApplication addNewLocalDrivingLicenseApplication = new AddNewLocalDrivingLicenseApplication();
            addNewLocalDrivingLicenseApplication.MdiParent = this;
            addNewLocalDrivingLicenseApplication.Show();
        }

        private void imterNationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScreen ManageInternationalLicenses = new ManageScreen(clsInternationalLicense.GetAllInternationalLicenses());

            ManageInternationalLicenses.MdiParent = this;

            ManageInternationalLicenses.Show();
        }

        private void drivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScreen ManageDrivers = new ManageScreen(clsDriver.GetAllDrivers());

            ManageDrivers.MdiParent = this;

            ManageDrivers.Show();
        }

        private void renewDrivingLicensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewDriverLicense renewDriverLicense = new RenewDriverLicense();
            renewDriverLicense.MdiParent = this;
            renewDriverLicense.Show();

        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementLicenseForDamagedOrLost replacementLicenseForDamagedOrLost = new ReplacementLicenseForDamagedOrLost();
            replacementLicenseForDamagedOrLost.MdiParent = this;
            replacementLicenseForDamagedOrLost.Show();
            
        }

        private void manageLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScreen ManageDetainedLicenses = new ManageScreen(clsDetainedLicense.GetAllDetainedLicenses());

            ManageDetainedLicenses.MdiParent = this;

            ManageDetainedLicenses.Show();
        }

        private void detatineLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDetain addNewDetain = new AddNewDetain();
            addNewDetain.MdiParent = this;
            addNewDetain.Show();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseLicenseDetain releaseLicenseDetain = new ReleaseLicenseDetain();
            releaseLicenseDetain.ShowDialog();
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey) // Escape key
            {
                this.Close(); // Close the form
            }
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localLicensToolStripMenuItem_Click(null, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
