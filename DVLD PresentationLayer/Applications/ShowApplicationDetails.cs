using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System.Applications
{
    public partial class ShowApplicationDetails : Form
    {

        private int _LocalAppID = -1;
        public ShowApplicationDetails(int LocalAppID)
        {

            this._LocalAppID = LocalAppID;

            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;



            InitializeComponent();
        }

        private void ShowApplicationDetails_Load(object sender, EventArgs e)
        {
            AppDetails.Load(_LocalAppID);
        }
    }
}
