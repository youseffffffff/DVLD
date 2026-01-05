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
using DVLD_Business_Layer;

namespace DVLD_System
{
    public partial class ChangePassword : Form
    {
        private int _id;
        public ChangePassword(int UserID)
        {
            _id = UserID;

            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
        }


        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValideForm()
        {
            if (User1.User.Password.ToString() != clsPasswordSecurity.ComputeHash(txtCurrentPassword.Text))
            {
                MessageBox.Show("Incurrect Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("Enter The New Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Enter The Confirm Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Incurrect Confirm Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btmSave_Click(object sender, EventArgs e)
        {
            if (!IsValideForm()) return;

            User1.User.Password = txtNewPassword.Text;

            if (User1.User.Save())                
            {
                MessageBox.Show("Password Changed Successfuly");
            }
            else
            {
                MessageBox.Show("Field To Change Password");
            }

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

            if (!User1.Load(_id))
            {
                MessageBox.Show("Dont Find User", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
