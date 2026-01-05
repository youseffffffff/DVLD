using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class FindPerson : Form
    {
        public FindPerson()
        {

            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;


            InitializeComponent();
        }


        

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;




        ~FindPerson()
        {



        }

        private void FindPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PersonFilter.P != null) DataBack?.Invoke(this, PersonFilter.P.PersonID);
            else DataBack?.Invoke(this, -1);
        }
    }
}
