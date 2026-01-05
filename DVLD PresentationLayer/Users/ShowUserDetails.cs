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


namespace DVLD_System
{
    public partial class ShowUserDetails : Form
    {
        public ShowUserDetails(int UserID)
        {
            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            if (clsUser.Find(UserID) != null)
            {
                User.Load(UserID);
            }
        }

        private void ShowUserDetails_Load(object sender, EventArgs e)
        {
            
        }
    }
}
