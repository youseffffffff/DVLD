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
    public partial class LicenseDetailsWithFilter : UserControl
    {
        public LicenseDetailsWithFilter()
        {
            InitializeComponent();
        }
        public clsLicense License;


        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                grbFilter.Enabled = _FilterEnabled;
            }
        }
        public bool Load(int ID)
        {
            try
            {
                License = clsLicense.FindByLicenseID(ID);
                if (License != null)
                {
                    LicenseCard.Load(License.LicenseID);
                }
                else
                {
                    MessageBox.Show("License not found.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid License ID.");
                return false;

            }
            return true;

        }


        private void Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrimaryNumber.Text))
            {
                MessageBox.Show("Please Enter a License ID.");
                return;
            }



            try
            {
                int licenseID = Convert.ToInt32(txtBrimaryNumber.Text);

                License = clsLicense.FindByLicenseID(licenseID);

                if (License != null)
                {
                    LicenseCard.Load(License.LicenseID);
                }
                else
                {
                    MessageBox.Show("License not found.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid License ID.");
            }
        }

        private void LicenseCard_Load(object sender, EventArgs e)
        {

        }
    }
}
