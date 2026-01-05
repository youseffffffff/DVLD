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
    public partial class PersonDetailsByFiltering : UserControl
    {
        public PersonDetailsByFiltering()
        {
            InitializeComponent();
            
        }
        public clsPerson P = null;
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrimaryNumber.Text))
            {                
                MessageBox.Show($"Enter The {cmbFindBy.Text} Please");
                return;
            }

            if (string.IsNullOrEmpty(cmbFindBy.Text))                
            {                  
                MessageBox.Show($"Choose Find By What");                 
                return;                
            }


            if (cmbFindBy.Text == "Person ID")
            {
                int result;
                if (int.TryParse(txtBrimaryNumber.Text, out result))
                    P = clsPerson.Find(Convert.ToInt32(result));
                else
                    MessageBox.Show($"Please Enter Just A Number");

            }
            else if (cmbFindBy.Text == "NationalNo")
                P = clsPerson.Find(txtBrimaryNumber.Text);

            //if (P.PersonID != -1)
            if (P == null)
            {
                MessageBox.Show($"Not Found Person With {cmbFindBy.Text}: {txtBrimaryNumber.Text}");
            }
            else
            {
                Person.Load(P.PersonID);

            }

        }





    }
}
