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
using DVLD_System.Properties;
namespace DVLD_System
{
    public partial class EditOrAddUser : Form
    {

        private int _UserID;

        clsUser User = null;
        private enum enMode { AddNew = 0, Update = 1 }

        enMode Mode;

        public EditOrAddUser(int UserID)
        {
            InitializeComponent();
            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;
            _UserID = UserID;

            User = clsUser.Find(UserID);

            if (User == null)
            {
                User = new clsUser();
                Mode = enMode.AddNew;
                Person.Enabled = false;
                btmSelectUser.Enabled = true;
            }
            else
            {
                Mode = enMode.Update;
                Person.Enabled = true;
                btmSelectUser.Enabled = false;


            }
        }
        private void FillObject()
        {

            Person.Load(User.PersonID);
            lblUserIDInfo.Text = User.UserID.ToString();
            txtPassword.Text = "????";
            txtUserName.Text = User.UserName.ToString();
            cbIsActive.Text = (User.IsActive) ? "Yes" : "No";
            lblIcon.Text = "Udate User";

        }

        private void SetEmpty()
        {
            lblIcon.Text = "Add New User";

            Person.Load(-1);
            lblUserIDInfo.Text = "????";
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
            cbIsActive.Text = string.Empty;


        }

        private void EditOrAddUser_Load(object sender, EventArgs e)
        {

            if (Mode == enMode.Update) FillObject();

            else SetEmpty();

        }

        bool SetFormDataIntoUser()
        {
            User.UserName = txtUserName.Text.ToString();
            User.Password = txtPassword.Text.ToString() != "????" ? txtPassword.Text.ToString() : User.Password;
            User.IsActive = (cbIsActive.Text == "Yes") ? true : false;
            User.PersonID = Person.P.PersonID;


            return true;
        }

        bool IsValidForm()
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please enter User Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(cbIsActive.Text))
            {
                MessageBox.Show("Please enter Is Active", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Person.P.PersonID == -1)
            {
                MessageBox.Show("Please Select A Person", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Mode == enMode.AddNew)
            {
                if (clsUser.IsPersonInUsersSystem(Person.P.PersonID))
                {
                    MessageBox.Show("This Person Was Added, Please Choose Another", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void btmSave_Click(object sender, EventArgs e)
        {

            if (!IsValidForm()) return;

            if (!SetFormDataIntoUser()) return;

            if (!User.Save())
            {
                MessageBox.Show("Fieled To Save Informatins", "Fieled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       

            switch (Mode)
            {
                case enMode.AddNew:

                    lblUserIDInfo.Text = User.UserID.ToString();

                    MessageBox.Show("User Login Successfuly", "Done", MessageBoxButtons.OK);

                    break;

                case enMode.Update:

                    MessageBox.Show("User Edit Successfuly", "Done", MessageBoxButtons.OK);

                    break;
            }

        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void SelectUser(object sender, int PersonID)
        {
            Person.Enabled = true;
            Person.Load(PersonID);
        }

        private void btmSelectUser_Click(object sender, EventArgs e)
        {
            FindPerson Find = new FindPerson();
            Find.DataBack += SelectUser;
            Find.ShowDialog();
        }

        private void lblIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
