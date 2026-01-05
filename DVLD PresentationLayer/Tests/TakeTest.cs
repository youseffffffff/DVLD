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
    public partial class TakeTest : Form
    {
        private clsTest Test;

        private clsTestAppointment appointment;
        public TakeTest(int appointmentID)
        {
            Test = new clsTest();
            this.appointment = clsTestAppointment.Find(appointmentID);


            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;



            InitializeComponent();
        }
        void Fill()
        {


            lblLocalAppIDInfo.Text = appointment.LocalApp.LocalAppID.ToString();

            lblAppClassInfo.Text = clsLicenseClass.Find(appointment.LocalApp.LicenseClassID).ClassName.ToString();

            lblAppPersonNameInfo.Text = clsPerson.Find(appointment.LocalApp.PersonID).FullName.ToString();

            lblTrailInfo.Text = clsTestAppointment.GetAllTestsAppointmentsByLocalAppID(appointment.TestType.TestTypeID, appointment.LocalApp.LocalAppID).Rows.Count.ToString();

            lblFeesInfo.Text = appointment.PaidFees.ToString();

            txtAppDateInfo.Text = appointment.AppointmentDate.ToString();


        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SetItems()
        {
            appointment.IsLocked = true;
            appointment.Save();

            Test.Notes = txtNotes.Text;
            Test.TestResult = Pass.Checked;
            Test.CreatedByUserID = clsCurrentUser.User.UserID;
            Test.TestAppointmentID = appointment.TestAppointmentID;
        }

        bool IsValidForm()
        {
            if (!Fail.Checked && !Pass.Checked)
            {
                MessageBox.Show("Select Result");
                return false;
            }

            return true;
        }
        private void btmSave_Click(object sender, EventArgs e)
        {
            if (!IsValidForm()) return;

            SetItems();


            if (Test.Save())
            {
                MessageBox.Show("Saved Successfuly");
                btmClose_Click(null,null);
            }

            else
            {
                MessageBox.Show("Field To Save");
                btmClose_Click(null, null);

            }

        }

        private void lblNotes_Load(object sender, EventArgs e)
        {
            Fill();
        }
    }
}
