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

namespace DVLD_System.Applications
{
    public partial class UpdateTestType : Form
    {

        public UpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            Type = clsTestType.Find(TestTypeID);

            this.Size = new Size(900, 500);

            // إلغاء خصائص التكبير والتصغير
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // جعل الفورم يبدأ في منتصف الشاشة
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        clsTestType Type = null;

        bool IsValidForm()
        {
            if (string.IsNullOrEmpty(txtTestTitleInfo.Text))
            {
                MessageBox.Show("Please enter Test Type Title", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtTestFeesInfo.Text))
            {
                MessageBox.Show("Please enter Test Type Fees", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(txtTestDescriptionInfo.Text))
            {
                MessageBox.Show("Please enter Test Description", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Update Test Type Successfuly");
                else
                    MessageBox.Show("Fieled To Save Informatins", "Fieled", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void FillObject()
        {
            lblIDInfo.Text = Type.TestTypeID.ToString();
            txtTestFeesInfo.Text = Type.TestFees.ToString();
            txtTestTitleInfo.Text = Type.TestTypeTitle.ToString();
            txtTestDescriptionInfo.Text = Type.TestDescription.ToString();
        }
        void SetObjectInfoToTypeObject()
        {


            Type.TestTypeID = Convert.ToInt32(lblIDInfo.Text);
            Type.TestTypeTitle = txtTestTitleInfo.Text;
            Type.TestFees = Convert.ToDouble(txtTestFeesInfo.Text);
            Type.TestDescription = txtTestDescriptionInfo.Text;


        }
        private void UpdateTestType_Load(object sender, EventArgs e)
        {
            if (Type == null) this.Close();

            FillObject();

        }
    }
}
