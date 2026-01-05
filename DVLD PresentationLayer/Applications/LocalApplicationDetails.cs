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


namespace DVLD_System.Applications
{
    public partial class AppDetails : UserControl
    {

        
        public AppDetails()
        {

            InitializeComponent();
        }

        public clsLocalDrivingLicenseApplication LocalApp = null;

        private void Fill(clsLocalDrivingLicenseApplication LocalApp)
        {
            lblLocalAppIDInfo.Text = LocalApp.LocalAppID.ToString();

            lblAppClassInfo.Text = clsLicenseClass.Find(LocalApp.LicenseClassID).ClassName.ToString();

            lblPassedTestsInfo.Text = clsLocalDrivingLicenseApplication.GetPassedTestsByLocalAppID(LocalApp.LocalAppID).ToString();

            lblAppIDInfo.Text = LocalApp.AppID.ToString();

            lblStatusInfo.Text = LocalApp.ApplicationStatusAsString.ToString();

            lblFeesInfo.Text = LocalApp.PaidFees.ToString();

            lblAppPersonNameInfo.Text = clsPerson.Find(LocalApp.PersonID).FirstName.ToString();

            lblAppTypeInfo.Text = clsApplicationType.Find(LocalApp.ApplicationTypeID).ApplicationTypeTitle.ToString();

            lblAppDateInfo.Text = LocalApp.ApplicationDate.ToString();

            lblStatusDateInfo.Text = LocalApp.LastStatusDate.ToString();
        }

        private void SetEmpty()
        {
            lblLocalAppIDInfo.Text = "????";

            lblAppClassInfo.Text = "????";

            lblPassedTestsInfo.Text = "????";

            lblAppIDInfo.Text = "????";

            lblStatusInfo.Text = "????";

            lblFeesInfo.Text = "????";

            lblAppPersonNameInfo.Text = "????";

            lblAppTypeInfo.Text = "????";

            lblAppDateInfo.Text = "????";

            lblStatusDate.Text = "????";
        }

        public bool Load(int LocalAppID)
        {
            LocalApp = clsLocalDrivingLicenseApplication.Find(LocalAppID);


            if (LocalApp != null)
            {
                Fill(LocalApp);

                return true;
            }

            else
            {
                SetEmpty();

                return false;
            }
        }

        private void ShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonDetails sp = new ShowPersonDetails(LocalApp.PersonID);
            sp.ShowDialog();
        }

        private void grpAppBasicInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
