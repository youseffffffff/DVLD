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
    public partial class AddNewLocalDrivingLicenseApplication : Form
    {

        clsLocalDrivingLicenseApplication App = new clsLocalDrivingLicenseApplication();
        public AddNewLocalDrivingLicenseApplication()
        {
            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;



            clsLocalDrivingLicenseApplication App = new clsLocalDrivingLicenseApplication();
            InitializeComponent();
        }


        private void SetClasses(ComboBox Classes)
        {
            Classes.Items.Clear();

            DataTable Licenses = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow Row in Licenses.Rows)
            {
                Classes.Items.Add(Row["ClassName"].ToString());
            }
        }

        
        bool IsValidForm()
        {
            if (string.IsNullOrEmpty(cbLicenseClasses.Text))
            {
                MessageBox.Show("Please enter License Class", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
          
            if (Person.P == null)
            {
                MessageBox.Show("Please Select A Person", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (clsLocalDrivingLicenseApplication.IsHasAnotherSameApplication(cbLicenseClasses.Text, Person.P.NationalNo.ToString()))
            {
                MessageBox.Show("This Person Already Has Same License Class Application", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


                    

            return true;
        }

        bool SetFormDataIntoAppObject()
        {
            App.LicenseClassID = clsLicenseClass.Find(cbLicenseClasses.Text).LicenseClassID;
            App.ApplicationTypeID = 1;
            App.ApplicationStatus = 1;
            App.PaidFees = clsApplicationType.Find(1).ApplicationFees;
            App.LastStatusDate = DateTime.Now;  
            App.PersonID = Person.P.PersonID;
            App.ApplicationDate = DateTime.Now;
            App.CreatedByUserID = clsCurrentUser.User.UserID;
            return true;
        }

        bool SetAppObjectIntoFormData()
        {

            lblAppDateInfo.Text = DateTime.Now.ToString();
            lblAppFeesInfo.Text = clsApplicationType.Find(1).ApplicationFees.ToString();
            lblCreateByInfo.Text = clsCurrentUser.User.UserID.ToString();

            return true;
        }

        private void btmSave_Click(object sender, EventArgs e)
        {
            if (!IsValidForm() || !SetFormDataIntoAppObject()) return;
           
              
            if (App.Save())
            {
                MessageBox.Show("Applicarion Added Successfuly");
            }

        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            if (!SetAppObjectIntoFormData()) this.Close();


            SetClasses(cbLicenseClasses);
        }
    }
}
