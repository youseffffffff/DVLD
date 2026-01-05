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
    public partial class ShowLicenseDetails : Form
    {
        clsLicense License;
        public ShowLicenseDetails(int LicenseID)
        {
            License = clsLicense.FindByLicenseID(LicenseID);


            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;


            InitializeComponent();
        }



        private void ShowLicenseDetails_Load(object sender, EventArgs e)
        {
            LicenseCard.Load(License.LicenseID);

        }
    }
}
