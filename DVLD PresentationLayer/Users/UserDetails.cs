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
    public partial class UserDetails : UserControl
    {
        public UserDetails()
        {
            InitializeComponent();
        }
        public clsUser User;
        private void Fill(int UserID)
        {
            PersonDetails.Load(User.PersonID);

            lblUserIDInfo.Text = User.UserID.ToString();
            lblUserNameInfo.Text = User.UserName.ToString();
            lblIsActiveInfo.Text = (User.IsActive) ? "Yes" : "No";

        }
        public bool Load(int UserID)
        {
            User = clsUser.Find(UserID);

            if (User == null) return false;

            Fill(UserID);
            return true;

             
        }

        private void lblIsActiveInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
