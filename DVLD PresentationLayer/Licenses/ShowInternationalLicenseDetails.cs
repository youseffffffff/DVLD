using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System.Licenses
{
    public partial class ShowInternationalLicenseDetails : Form
    {
        int IntLicenseID;
        public ShowInternationalLicenseDetails(int IntLicenseID)
        {
            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;


            this.IntLicenseID = IntLicenseID;
            InitializeComponent();
        }

        private void ShowInternationalLicenseDetails_Load(object sender, EventArgs e)
        {
            if (IntLicenseInfo.Load(IntLicenseID))
            {
            }
            else
            {
                MessageBox.Show("Feild To load License Data");
            }
        }
    }
}
