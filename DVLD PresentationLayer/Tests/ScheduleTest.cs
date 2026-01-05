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


namespace DVLD_System.Tests
{
    public partial class ScheduleTest : Form
    {
        private int _TestAppointmentID;
        private int _LocalAppID;
        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;

        public ScheduleTest(int LocalAppID, clsTestType.enTestType TestType, int TestAppointmentID = -1)
        {
            _TestAppointmentID = TestAppointmentID;
            _LocalAppID = LocalAppID;
            _TestTypeID = TestType;


            InitializeComponent();

            this.Size = new Size(450, 650);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;
        }




        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest.TestTypeID = _TestTypeID;
            ctrlScheduleTest.LoadInfo(_LocalAppID, _TestAppointmentID);
        }
    }
}
