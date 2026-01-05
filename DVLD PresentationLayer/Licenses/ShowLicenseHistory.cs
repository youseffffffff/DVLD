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
    public partial class ShowLicenseHistory : Form
    {
        int PersonID;
        public ShowLicenseHistory(int PersonID)
        {


            this.PersonID = PersonID;

            InitializeComponent();

            this.Size = new Size(1000, 700);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        private void RefreshData()
        {
            ctrlDriverLicenses1.Load(PersonID);
        }
        private void ShowLicenseHistory_Load(object sender, EventArgs e)
        {
            if(!Person.Load(PersonID))
            {
                MessageBox.Show("Fieled To Load Person Info");
                return;
            }
            RefreshData();
        }

    }
}
