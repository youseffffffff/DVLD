using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business_Layer;

namespace DVLD_System.Applications
{
    public partial class UpdateApplicationType : Form
    {
        clsApplicationType Type = null;
        public UpdateApplicationType(int ApplicationTypeID)
        {
            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;



            Type = clsApplicationType.Find(ApplicationTypeID);

            InitializeComponent();
        }
        bool IsValidForm()
        {
            if (string.IsNullOrEmpty(txtApplicationTitleInfo.Text))
            {
                MessageBox.Show("Please enter Application Type Title", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtApplicationFeesInfo.Text))
            {
                MessageBox.Show("Please enter Application Type Fees", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmSave_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                SetObjectInfoToTypeObject();

                if (Type.Save())
                    MessageBox.Show("Update Application Type Successfuly");
                else
                    MessageBox.Show("Fieled To Save Informatins", "Fieled", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void FillObject()
        {
            lblIDInfo.Text = Type.ApplicationTypeID.ToString();
            txtApplicationFeesInfo.Text = Type.ApplicationFees.ToString();
            txtApplicationTitleInfo.Text = Type.ApplicationTypeTitle.ToString();
        }
        void SetObjectInfoToTypeObject()
        {


            Type.ApplicationTypeID = Convert.ToInt32(lblIDInfo.Text);
            Type.ApplicationTypeTitle = txtApplicationTitleInfo.Text;
            Type.ApplicationFees = Convert.ToDouble(txtApplicationFeesInfo.Text);


        }
        private void UpdateApplicationType_Load(object sender, EventArgs e)
        {
            if (Type == null) this.Close();

            FillObject();
        
        }
    }
}
