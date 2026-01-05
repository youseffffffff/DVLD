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


using static System.Net.Mime.MediaTypeNames;


namespace DVLD_System.Tests
{
    public partial class VisionTestAppointmet : Form
    {

        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        private int _LocalAppID;

        public VisionTestAppointmet(int LocalAppID, clsTestType.enTestType TestTypeID)
        {

            
            _LocalAppID = LocalAppID;
            _TestTypeID = TestTypeID;

            this.Size = new Size(1000, 700);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;

     
            InitializeComponent();
        }

        int SelectedID()
        {
            int SelectedID = Convert.ToInt32(Appointments.Rows[Appointments.CurrentRow.Index].Cells[0].Value);
            return SelectedID;
        }

        private void RefreshData()
        {
            Appointments.DataSource = clsTestAppointment.GetAllTestsAppointmentsByLocalAppID((int)_TestTypeID, _LocalAppID);
            lblRecordsCount.Text = "# Records: " + Appointments.RowCount.ToString();
        }

        private void VisionTestAppoinment_Load(object sender, EventArgs e)
        {
            if (_LocalAppID == -1 || !AppInfo.Load(_LocalAppID)) this.Close();

            RefreshData();
        }


        private bool IsValid()
        {
            if (clsLocalDrivingLicenseApplication.IsThereAnActiveScheduledTest(_LocalAppID, _TestTypeID))
            {
                MessageBox.Show("There Is Already Active Appointment");
                return false;
            }

            if (clsLocalDrivingLicenseApplication.GetPassedTestsByLocalAppID(_LocalAppID) == (int)_TestTypeID)
            {
                MessageBox.Show("Your Passed This Test");
                return false;
            }


            return true;
        }
        private void picAddNewAppointment_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
                
           

            ScheduleTest scheduleTest = new ScheduleTest(_LocalAppID, _TestTypeID);

            scheduleTest.ShowDialog();

            RefreshData();

        }

        private bool IsLocked(int AppointmentID)
        {
            clsTestAppointment TestAppointment = clsTestAppointment.Find(SelectedID());

            if (TestAppointment.IsLocked)
            {
                MessageBox.Show("This Appointment Is Locked");
                return false;
            }
            return true;
        }

        private void EditAppointmet_Click(object sender, EventArgs e)
        {

            if (!IsLocked(SelectedID())) return;
 


            ScheduleTest scheduleTest = new ScheduleTest(_LocalAppID, _TestTypeID, SelectedID());

            scheduleTest.ShowDialog();

            RefreshData();
        }

        private void TakeTest_Click(object sender, EventArgs e)
        {
            if (!IsLocked(SelectedID())) return;


            TakeTest takeTest = new TakeTest(SelectedID());
            takeTest.ShowDialog();
            RefreshData();
        }
    }
}
