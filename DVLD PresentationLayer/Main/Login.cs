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
using System.IO;


namespace DVLD_System
{
    public partial class Login : Form
    {
        public Login()
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

        
        string UserName;

        string Password;

        public bool PathOfUserNameAndPasswordcs { get; private set; }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Please Enter The User Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter The Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUser User = clsUser.Find(txtUserName.Text, txtPassword.Text);

            if (User != null)
            {
                if (RememberMe.Checked)
                {

                    if (clsLoginData.SetValue(txtUserName.Text, txtPassword.Text))
                    {

                    }

                }
                else
                {
                    if (clsLoginData.DeleteValue())
                    {

                    }
                }

                Main main = new Main(User.UserID);
                clsCurrentUser.SetCurrentUser(User.UserID);
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incurrect UserName Or Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (clsLoginData.GetValue(ref UserName, ref Password))
            {
                txtPassword.Text = Password;
                txtUserName.Text = UserName;

            }
            else
            {

            }

        }

    }
}
