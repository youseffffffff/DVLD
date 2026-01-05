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

namespace DVLD_System.Applications
{
    public partial class InternationalApplicationDetails : UserControl
    {
        public clsInternationalLicense IntLicense;
        public clsApplication App;

        public InternationalApplicationDetails()
        {
            InitializeComponent();
        }
        bool Fill()
        {

            try
            {

                lblInternationalLicenseInfo.Text = IntLicense.InternationalLicenseID.ToString();
                lblInternationalAppIDInfo.Text = IntLicense.AppID.ToString();
                lblApplicationDateInfo.Text = App.ApplicationDate.ToString();
                lblLocalLicenseIDInfo.Text = IntLicense.IssuedUsingLocalLicenseID.ToString();
                lblIssueDateInfo.Text = IntLicense.IssueDate.ToString();
                lblExpirationDateInfo.Text = IntLicense.ExpirationDate.ToString();
                lblFeesInfo.Text = App.PaidFees.ToString();
                lblCreatedByInfo.Text = clsCurrentUser.User.FirstName.ToString();
            }

            catch(Exception ex)
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
