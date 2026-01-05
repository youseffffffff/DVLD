using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DVLD_Buisness;
using DVLD_Business_Layer;
using DVLD_System.Applications;
using DVLD_System.Detains;
using DVLD_System.Licenses;
using DVLD_System.Properties;
using DVLD_System.Tests;

namespace DVLD_System
{
    public partial class ManageScreen : Form
    {

        private DataTable DataWithAllMembers
        {
            get
            {
                switch (managed)
                {
                    case enManaged.Users:
                        return clsUser.GetAllUsers();

                        break;

                    case enManaged.People:
                        return clsPerson.GetAllPeople();

                        break;

                    case enManaged.Drivers:
                        return clsDriver.GetAllDrivers();

                        break;

                    case enManaged.DetainedLicenses:
                        return clsDetainedLicense.GetAllDetainedLicenses();

                        break;

                    case enManaged.TestTypes:
                        return clsTestType.GetAllTestTypes();

                        break;

                    case enManaged.LocalDrivingLicenseApplications:
                        return clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

                        break;

                    case enManaged.InternationalLicenses:
                        return clsInternationalLicense.GetAllInternationalLicenses();

                        break;

                    case enManaged.ApplicationTypes:
                        return clsApplicationType.GetAllApplicationTypes();

                        break;
                }

                return null;
            }
        }



        //Constructor
        public ManageScreen(DataTable Table)
        {
            InitializeComponent();

            if (Table != null)
            {
                this.Size = new Size(1000, 500);


                // إلغاء خصائص التكبير والتصغير
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.MaximizeBox = false;
                this.MinimizeBox = false;

                // جعل الفورم يبدأ في منتصف الشاشة
                this.StartPosition = FormStartPosition.CenterScreen;



                //Data.BackgroundColor = Color.Black;
                Data.ForeColor = Color.Black; 

                

                SetManageScreenInfo(Table);

            }
        }


        //Managed enum
        public enum enManaged { Users , People , DetainedLicenses , Drivers ,  LocalDrivingLicenseApplications , InternationalLicenses , TestTypes, ApplicationTypes };
        private enManaged managed {  get; set; }


        //Set Columns
        string[] ColumnUsers = { "None", "UserID", "PersonID", "UserName", "IsActive" };
        string[] ColumnPeople = { "None", "PersonID", "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "CountryName", "Gendor", "Phone", "Email" };
        string[] ColumnDetainedLicenses = { "None", "DetainID", "LicenseID", "FineFees", "ApplicationRelease" };
        string[] ColumnLocalDrivingLicenseApplications = { "None", "LocalDrivingLicenseApplicationID", "NationalNo", "ClassName", "ApplicationStatus" };
        string[] ColumnInternationalLicenses = { "None", "InternationalLicenseID", "LocalLicenseID", "ApplicationID", "DriverID", "IsActive", };
        string[] ColumnDrivers = { "None", "DriverID", "PersonID" };


        //Selected ID
        int SelectedID()
        {
            int SelectedID = Convert.ToInt32(Data.Rows[Data.CurrentRow.Index].Cells[0].Value);
            return SelectedID; 
        }


        //Refresh Methods
        private void SetRecords()
        {
            lblRecordsCount.Text = "# Records: " + Data.RowCount.ToString();

        }
        private void RefreshData()
        {            
            Data.DataSource = DataWithAllMembers;

            SetRecords();
        }



        //Set Form Informations
        void SetManageScreenInfo(DataTable Table)
        {
            switch (Table.TableName)
            {

                case "Users":

                    SetAsUsers(Table);

                    break;

                case "People":

                    SetAsPeople(Table);

                    break;

                case "Drivers":

                    SetAsDrivers(Table);

                    break;

                case "DetainedLicenses":

                    SetAsDetainedLicenses(Table);

                    break;

                case "TestTypes":

                    SetAsTestTypes(Table);

                    break;

                case "LocalDrivingLicenseApplications":

                    SetAsLocalDrivingLicenseApplications(Table);

                    break;

                case "InternationalLicenses":

                    SetAsInternationalLicenses(Table);

                    break;

                case "ApplicationTypes":

                    SetAsApplicationTypes(Table);

                    break;

            }
        }
        void SetAsUsers(DataTable Table)
        {
            //Set Title
            lblTitle.Text = "Manage " + Table.TableName;

            //Set Form Name
            this.Name = "Manage " + Table.TableName;

            //Set Context Menue Strip
            Data.ContextMenuStrip = cmsUserActions;

            //Set Combo Box
            cbFilter.Items.Clear();
            foreach (string Culomn in ColumnUsers)
            {
                cbFilter.Items.Add(Culomn);
            }

            //Set enum
            managed = enManaged.Users;

            //Set AddNew Button Visible 
            btmAddNewRecord.Visible = true;

            //Set grbFilter
            grbFilter.Visible = true;

            //Set icon
            icon.Image = Resources.Users_2_400;

            //Set Data
            RefreshData();
        }
        void SetAsPeople(DataTable Table)
        {
            //Set Title
            lblTitle.Text = "Manage " + Table.TableName;

            //Set Form Name
            this.Name = "Manage " + Table.TableName;

            //Set Context Menue Strip
            Data.ContextMenuStrip = cmsPersonActions;

            //Set Combo Box
            cbFilter.Items.Clear();
            foreach (string Culomn in ColumnPeople)
            {
                cbFilter.Items.Add(Culomn);
            }

            //Set enum
            managed = enManaged.People;

            //Set AddNew Button Visible 
            btmAddNewRecord.Visible = true;

            //Set grbFilter
            grbFilter.Visible = true;

            //Set icon
            icon.Image = Resources.People_400;

            //Set Data
            RefreshData();
        }
        void SetAsDrivers(DataTable Table)
        {
            //Set Title
            lblTitle.Text = "Manage " + Table.TableName;

            //Set Form Name
            this.Name = "Manage " + Table.TableName;

            //Set Context Menue Strip
            Data.ContextMenuStrip = cmsDriverActions;

            //Set Combo Box
            cbFilter.Items.Clear();
            foreach (string Culomn in ColumnDrivers)
            {
                cbFilter.Items.Add(Culomn);
            }

            //Set enum
            managed = enManaged.Drivers;

            //Set AddNew Button Visible 
            btmAddNewRecord.Visible = false;

            //Set grbFilter
            grbFilter.Visible = true;

            //Set icon
            icon.Image = Resources.Drivers_64;

            //Set Data
            RefreshData();
        }
        void SetAsDetainedLicenses(DataTable Table)
        {
            //Set Title
            lblTitle.Text = "Manage " + Table.TableName;

            //Set Form Name
            this.Name = "Manage " + Table.TableName;

            //Set Context Menue Strip
            Data.ContextMenuStrip = cmsDetaainsActions;

            //Set Combo Box
            cbFilter.Items.Clear();
            foreach (string Culomn in ColumnDetainedLicenses)
            {
                cbFilter.Items.Add(Culomn);
            }

            //Set enum
            managed = enManaged.DetainedLicenses;

            //Set AddNew Button Visible 
            btmAddNewRecord.Visible = true;

            //Set grbFilter
            grbFilter.Visible = true;

            //Set icon
            icon.Image = Resources.Detained_Driving_License_32;

            //Set Data
            RefreshData();
        }
        void SetAsTestTypes(DataTable Table)
        {


            //Set Title
            lblTitle.Text = "Manage " + Table.TableName;

            //Set Form Name
            this.Name = "Manage " + Table.TableName;

            //Set Context Menue Strip
            Data.ContextMenuStrip = cmsTestTypeActions;

            //Set enum
            managed = enManaged.TestTypes;

            //Set grbFilter
            grbFilter.Visible = false;

            //Set icon
            icon.Image = Resources.TestType_32;

            //Set Data
            RefreshData();

        }
        void SetAsLocalDrivingLicenseApplications(DataTable Table)
        {
            //Set Title
            lblTitle.Text = "Manage " + Table.TableName;

            //Set Form Name
            this.Name = "Manage " + Table.TableName;

            //Set Context Menue Strip
            Data.ContextMenuStrip = cmsLocalAppActions;

            //Set Combo Box
            cbFilter.Items.Clear();
            foreach (string Culomn in ColumnLocalDrivingLicenseApplications)
            {
                cbFilter.Items.Add(Culomn);
            }

            //Set enum
            managed = enManaged.LocalDrivingLicenseApplications;

            //Set AddNew Button Visible 
            btmAddNewRecord.Visible = true;

            //Set grbFilter
            grbFilter.Visible = true;

            //Set icon
            icon.Image = Resources.LocalDriving_License;

            //Set Data
            RefreshData();
        }
        void SetAsInternationalLicenses(DataTable Table)
        {

            //Set Title
            lblTitle.Text = "Manage " + Table.TableName;

            //Set Form Name
            this.Name = "Manage " + Table.TableName;

            //Set Combo Box
            cbFilter.Items.Clear();
            foreach (string Culomn in ColumnInternationalLicenses)
            {
                cbFilter.Items.Add(Culomn);
            }

            //Set enum
            managed = enManaged.InternationalLicenses;

            //Set AddNew Button Visible 
            btmAddNewRecord.Visible = true;

            //Set grbFilter
            grbFilter.Visible = true;

            //Set icon
            icon.Image = Resources.International_32;

            //Set Data
            RefreshData();
        }
        void SetAsApplicationTypes(DataTable Table)
        {

            //Set Title
            lblTitle.Text = "Manage " + Table.TableName;

            //Set Form Name
            this.Name = "Manage " + Table.TableName;

            //Set Context Menue Strip
            Data.ContextMenuStrip = cmsAppTypeActions;

            //Set enum
            managed = enManaged.ApplicationTypes;

            //Set grbFilter
            grbFilter.Visible = false;

            //Set icon
            icon.Image = Resources.ApplicationType;

            //Set Data
            RefreshData();
        }



        //Filter The Table
        DataTable FilterUsersData(DataTable Table)
        {
            if (cbFilter.Text == "IsActive")
            {
                if (cbIsActive.Text == "All")
                {
                    RefreshData();
                    Table = DataWithAllMembers;
                    return Table;
                }
                string IsActiveCulomn = (cbIsActive.Text == "Yes") ? "1" : "0";
                Table = clsUser.GetAllUsersOrderByColumn(IsActiveCulomn, cbFilter.Text);
            }

            else
            {
                Table = clsUser.GetAllUsersOrderByColumn(txtFilter.Text.Trim(), cbFilter.Text);
            }

            return Table;
        }
        DataTable FilterPeopleData(DataTable Table)
        {
            if (cbFilter.Text == "Gendor")
            {
                if (cbGendor.Text == "All")
                {
                    RefreshData();
                    Table = DataWithAllMembers;
                    return Table;
                }
                string GendorCulomn = (cbGendor.Text == "Male") ? "0" : "1";
                Table = clsPerson.GetAllPeopleOrderByColumn(GendorCulomn, cbFilter.Text);
            }
            else
            {
                Table = clsPerson.GetAllPeopleOrderByColumn(txtFilter.Text.Trim(), cbFilter.Text);
            }

            return Table;

        }
        DataTable FilterDriversData(DataTable Table)
        {            
            Table = clsDriver.GetAllDriversOrderByColumn(txtFilter.Text.Trim(), cbFilter.Text);
          
            return Table;
        }
        DataTable FilterDetainedLicensesData(DataTable Table)
        {

            Table = clsDetainedLicense.GetAllDetainedLicensesByColumn(txtFilter.Text.Trim(), cbFilter.Text);

            return Table;

        }
        DataTable FilterTestTypesData(DataTable Table)
        {


            return Table;

        }
        DataTable FilterLocalDrivingLicenseApplicationsData(DataTable Table)
        {
            if (cbFilter.Text == "ApplicationStatus")
            {
                if (cbStatus.Text == "All")
                {
                    RefreshData();
                    Table = DataWithAllMembers;
                    return Table;
                }
                string StatusCulomn = (cbStatus.Text == "New") ? "1" : (cbStatus.Text == "Cancelled") ? "2": "3";
                Table = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplicationsByColumn(StatusCulomn, cbFilter.Text);
            }
            else
            {
                Table = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplicationsByColumn(txtFilter.Text.Trim(), cbFilter.Text);

            }

            return Table;

        }
        DataTable FilterInternationalLicensesData(DataTable Table)
        {
            if (cbFilter.Text == "IsActive")
            {
                string IsActiveCulomn = (cbIsActive.Text == "Yes") ? "1" : (cbIsActive.Text == "No") ? "0" : "";
                Table = clsInternationalLicense.GetAllInternationalLicensesByColumn(IsActiveCulomn, cbFilter.Text);


            }
            else
            {
                Table = clsInternationalLicense.GetAllInternationalLicensesByColumn(txtFilter.Text.Trim(), cbFilter.Text);

            }

            return Table;

        }
        DataTable FilterApplicationTypesData(DataTable Table)
        {

            return Table;

        }
        


        //Close The Form
        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }


        //Filter Options
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {


            cbIsActive.Text = string.Empty;
            txtFilter.Text = string.Empty;
            cbGendor.Text = string.Empty;
            cbStatus.Text = string.Empty; 



            if (cbFilter.Text == "None")
            {
                RefreshData();
                cbIsActive.Visible = false;
                txtFilter.Visible = false;
                cbGendor.Visible = false;
                cbStatus.Visible = false;
                return;
            }

            switch(managed)
            {
                case enManaged.Users:

                    if (cbFilter.Text == "IsActive")
                    {
                        cbIsActive.Visible = true;
                        txtFilter.Visible = false;
                        cbGendor.Visible = false;
                        cbStatus.Visible = false;
                    }
                    else
                    {
                        cbIsActive.Visible = false;
                        txtFilter.Visible = true;
                        cbGendor.Visible = false;
                        cbStatus.Visible = false;

                    }

                    break;
                    
                case enManaged.People:

                    if (cbFilter.Text == "Gendor")
                    {
                        cbIsActive.Visible = false;
                        txtFilter.Visible = false;
                        cbGendor.Visible = true;
                        cbStatus.Visible = false;
                    }
                    else
                    {
                        cbIsActive.Visible = false;
                        txtFilter.Visible = true;
                        cbGendor.Visible = false;
                        cbStatus.Visible = false;

                    }

                    break;

                case enManaged.Drivers:
                       
                    cbIsActive.Visible = false;                       
                    txtFilter.Visible = true;                     
                    cbGendor.Visible = false;                      
                    cbStatus.Visible = false;                    

                    break;

                case enManaged.DetainedLicenses:
                    
                    cbIsActive.Visible = false;                       
                    txtFilter.Visible = true;                       
                    cbGendor.Visible = false;                       
                    cbStatus.Visible = false;
                  
                    break;

                case enManaged.TestTypes:

                    cbIsActive.Visible = false;
                    txtFilter.Visible = true;
                    cbGendor.Visible = false;
                    cbStatus.Visible = false;

                    break;

                case enManaged.LocalDrivingLicenseApplications:

                    if (cbFilter.Text == "ApplicationStatus")
                    {
                        cbIsActive.Visible = false;
                        txtFilter.Visible = false;
                        cbGendor.Visible = false;
                        cbStatus.Visible = true;
                    }
                    else
                    {
                        cbIsActive.Visible = false;
                        txtFilter.Visible = true;
                        cbGendor.Visible = false;
                        cbStatus.Visible = false;

                    }

                    break;

                case enManaged.InternationalLicenses:

                    if (cbFilter.Text == "IsActive")
                    {
                        cbIsActive.Visible = true;
                        txtFilter.Visible = false;
                        cbGendor.Visible = false;
                        cbStatus.Visible = false;
                    }
                    else
                    {
                        cbIsActive.Visible = false;
                        txtFilter.Visible = true;
                        cbGendor.Visible = false;
                        cbStatus.Visible = false;

                    }

                    break;

                case enManaged.ApplicationTypes:

                    cbIsActive.Visible = false;
                    txtFilter.Visible = true;
                    cbGendor.Visible = false;
                    cbStatus.Visible = false;

                    break;
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            if (txtFilter.Text == "")
            {
                RefreshData();
                return;
            }

            DataTable TableAfterFilter = DataWithAllMembers;

            switch (managed)
            {
                case enManaged.Users:
                    Data.DataSource = FilterUsersData(TableAfterFilter);


                    break;

                case enManaged.People:
                    Data.DataSource = FilterPeopleData(TableAfterFilter);

                    break;

                case enManaged.Drivers:
                    Data.DataSource = FilterDriversData(TableAfterFilter);

                    break;

                case enManaged.DetainedLicenses:
                    Data.DataSource = FilterDetainedLicensesData(TableAfterFilter);

                    break;

                case enManaged.TestTypes:
                    Data.DataSource = FilterTestTypesData(TableAfterFilter);

                    break;

                case enManaged.LocalDrivingLicenseApplications:
                    Data.DataSource = FilterLocalDrivingLicenseApplicationsData(TableAfterFilter);

                    break;

                case enManaged.InternationalLicenses:
                    Data.DataSource = FilterInternationalLicensesData(TableAfterFilter);

                    break;

                case enManaged.ApplicationTypes:
                    Data.DataSource = FilterApplicationTypesData(TableAfterFilter);

                    break;
            }
        }
        private void cbGendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable TableAfterFilter = new DataTable();

            Data.DataSource = FilterPeopleData(TableAfterFilter);
        }
        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable TableAfterFilter = new DataTable();

            Data.DataSource = FilterLocalDrivingLicenseApplicationsData(TableAfterFilter);
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable TableAfterFilter = new DataTable();

            switch (managed)
            {
                case enManaged.Users:
                    Data.DataSource = FilterUsersData(TableAfterFilter);


                    break;

                case enManaged.InternationalLicenses:
                    Data.DataSource = FilterInternationalLicensesData(TableAfterFilter);


                    break;
            }
        }

        
        //Add New Record
        private void btmAddNewRecord_Click(object sender, EventArgs e)
        {
            switch (managed)
            {
                case enManaged.Users:
                    EditOrAddUser UserDetails = new EditOrAddUser(-1);
                    UserDetails.ShowDialog();
                    break;

                case enManaged.People:
                    EditOrAddPerson AddNew = new EditOrAddPerson(-1);
                    AddNew.ShowDialog();
                    break;

                case enManaged.DetainedLicenses:
                    AddNewDetain addNewDetain = new AddNewDetain();
                    addNewDetain.ShowDialog();
                    break;

                case enManaged.TestTypes:

                    break;

                case enManaged.LocalDrivingLicenseApplications:
                    AddNewLocalDrivingLicenseApplication addNewLocalDrivingLicenseApplication = new AddNewLocalDrivingLicenseApplication();
                    addNewLocalDrivingLicenseApplication.ShowDialog();
                    break;

                case enManaged.InternationalLicenses:
                    AddNewInternationalLicense addNewInternationalLicense = new AddNewInternationalLicense();
                    addNewInternationalLicense.ShowDialog();
                    break;

                case enManaged.ApplicationTypes:

                    break;
            }

            RefreshData();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateApplicationType updateApplicationType = new UpdateApplicationType(SelectedID());
            updateApplicationType.ShowDialog();
            RefreshData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrAddUser UserDetails = new EditOrAddUser(SelectedID());
            UserDetails.ShowDialog();
            RefreshData();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrAddUser UserDetails = new EditOrAddUser(-1);
            UserDetails.ShowDialog();
            RefreshData();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserDetails UserDetails = new ShowUserDetails(SelectedID());
            UserDetails.ShowDialog();
            RefreshData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsUser.DeleteUserByID(SelectedID()))
            {
                MessageBox.Show("Fieled To Delete User Because He Has Sum TransActions In The System", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Done Delete Successfuly");
            }
            RefreshData();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(SelectedID());
            changePassword.ShowDialog();
            RefreshData();
        }

        private void editPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrAddPerson EditForm = new EditOrAddPerson(SelectedID());
            EditForm.ShowDialog();
            RefreshData();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrAddPerson AddNew = new EditOrAddPerson(-1);
            AddNew.ShowDialog();
            RefreshData();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowPersonDetails ShowDetails = new ShowPersonDetails(SelectedID());
            ShowDetails.ShowDialog();
            RefreshData();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!clsPerson.DeletePersonByID(SelectedID()))
            {
                MessageBox.Show("Fieled To Delete Person Because He Has Sum TransActions In The System", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Done Delete Successfuly");
            }
            RefreshData();
        }

        private void ShowAppDetails_Click(object sender, EventArgs e)
        {
            ShowApplicationDetails showApplicationDetails = new ShowApplicationDetails(SelectedID());
            showApplicationDetails.ShowDialog();
            RefreshData();
        }

        private void DeleteApp_Click(object sender, EventArgs e)
        {
            if (clsLocalDrivingLicenseApplication.DeleteApplicationByID(SelectedID()))
            {
                MessageBox.Show("Application Deleted Successfuly");

            }
            else
            {
                MessageBox.Show("Feiled To Delete Application");

            }

            RefreshData();
        }

        private void CancelApp_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication App = clsLocalDrivingLicenseApplication.Find(SelectedID());

            if (App == null) return;

            if (App.ApplicationStatus == 2)
            {
                MessageBox.Show("Application Is Already Cancelled");
                return;
            }
            else
            {
                App.ApplicationStatus = 2;
                if (App.Save())
                {
                    MessageBox.Show("Application Cancelled Successfuly");

                }
            }

            RefreshData();
        }

        private void EditApp_Click(object sender, EventArgs e)
        {

        }

        private void VistionTest_Click(object sender, EventArgs e)
        {
            VisionTestAppointmet testAppoinment = new VisionTestAppointmet(SelectedID(), clsTestType.enTestType.VisionTest);
            testAppoinment.ShowDialog();
            RefreshData();
        }

        private void WrittenTest_Click(object sender, EventArgs e)
        {
            VisionTestAppointmet testAppoinment = new VisionTestAppointmet(SelectedID(), clsTestType.enTestType.WrittenTest);
            testAppoinment.ShowDialog();
            RefreshData();
        }

        private void StreetTest_Click(object sender, EventArgs e)
        {
            VisionTestAppointmet testAppoinment = new VisionTestAppointmet(SelectedID(), clsTestType.enTestType.StreetTest);
            testAppoinment.ShowDialog();
            RefreshData();
        }

        private void IssueLicense_Click(object sender, EventArgs e)
        {
            IssueLicense issueLicense = new IssueLicense(SelectedID());
            issueLicense.ShowDialog();
            RefreshData();
        }

        private void ShowLicense_Click(object sender, EventArgs e)
        {
            ShowLicenseDetails showLicenseDetails = new ShowLicenseDetails(clsLicense.FindByApplicationID(clsLocalDrivingLicenseApplication.Find(SelectedID()).AppID).LicenseID);
            showLicenseDetails.ShowDialog();
            RefreshData();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenseHistory showLicenseHistory = new ShowLicenseHistory(clsLocalDrivingLicenseApplication.Find(SelectedID()).PersonID);

            showLicenseHistory.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UpdateTestType updateApplicationType = new UpdateTestType(SelectedID());
            updateApplicationType.ShowDialog();
            RefreshData();
        }

        private void ReleaseOption_Click(object sender, EventArgs e)
        {
            string IsReleased = Data.Rows[Data.CurrentRow.Index].Cells[4].Value.ToString();

            if (IsReleased == "Yes")
            {
                MessageBox.Show("This Detain Has Been Released");
            }

            else
            {           
                ReleaseLicenseDetain releaseLicenseDetain = new ReleaseLicenseDetain(clsDetainedLicense.FindByDetainID(SelectedID()).LicenseID);           
                releaseLicenseDetain.ShowDialog();           
                RefreshData();
            }



        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ShowLicenseHistory showLicenseHistory = new ShowLicenseHistory(clsDriver.FindByDriverID(SelectedID()).PersonID);
            showLicenseHistory.ShowDialog();
            RefreshData();
        }

        private void cmsLocalAppActions_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {




            clsLocalDrivingLicenseApplication LocalApp = clsLocalDrivingLicenseApplication.Find(SelectedID());


            



            switch (LocalApp.ApplicationStatus)
            {
                case 1:

                    foreach (ToolStripItem item in cmsLocalAppActions.Items)
                    {
                        item.Enabled = true;                        
                    }

                    switch (clsLocalDrivingLicenseApplication.GetPassedTestsByLocalAppID(LocalApp.LocalAppID))
                    {
                        case 0:
                            VistionTest.Enabled = true;
                            WrittenTest.Enabled = false;
                            StreetTest.Enabled = false;

                            IssueLicense.Enabled = false;
                            ShowLicense.Enabled = false;

                            break;

                        case 1:
                            VistionTest.Enabled = false;
                            WrittenTest.Enabled = true;
                            StreetTest.Enabled = false;

                            IssueLicense.Enabled = false;
                            ShowLicense.Enabled = false;

                            break;

                        case 2:
                            VistionTest.Enabled = false;
                            WrittenTest.Enabled = false;
                            StreetTest.Enabled = true;

                            IssueLicense.Enabled = false;
                            ShowLicense.Enabled = false;

                            break;

                        case 3:
                            VistionTest.Enabled = false;
                            WrittenTest.Enabled = false;
                            StreetTest.Enabled = false;
                            Tests.Enabled = false;


                            IssueLicense.Enabled = true;
                            ShowLicense.Enabled = false;

                            break;

                    }



                    break;
                    
                case 2:

                    foreach(ToolStripItem item in cmsLocalAppActions.Items)
                    {
                        if (item != ShowLicenseHistory && item != DeleteApp)
                        {
                            item.Enabled = false;
                        }
                    }

                    return;

                    break;

                case 3:

                    foreach (ToolStripItem item in cmsLocalAppActions.Items)
                    {
                        if (item != ShowAppDetails && item != ShowLicenseHistory && item != ShowLicense)
                        {
                            item.Enabled = false;
                        }
                        else
                        {
                            item.Enabled = true;
                        }
                    }
                               
                      


                    return;

                    break;
            
            
            }




        }

        private void ManageScreen_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void cmsDetaainsActions_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
