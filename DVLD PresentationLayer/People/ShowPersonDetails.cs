using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class ShowPersonDetails : Form
    {
        private int _ID = -1;
        public ShowPersonDetails(int ID)
        {

            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;

            this._ID = ID;
            InitializeComponent();
        }

        private void ShowPersonDetails_Load(object sender, EventArgs e)
        {
            Person.Load(this._ID);

        }
    }
}
