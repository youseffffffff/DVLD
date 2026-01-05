using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer
{
    public class clsUser : clsPerson
    {
        public clsUser()
        {

            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.PersonID = -1;
            this.NationalNo = string.Empty;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.Gendor = -1;
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.NationalityCountryID = -1;
            this.ImagePath = string.Empty;

            Mode = enMode.AddNew;
        }
        public clsUser
            (int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {

            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            clsPerson UserPersonal = clsPerson.Find(this.PersonID);

            this.PersonID = UserPersonal.PersonID;
            this.NationalNo = UserPersonal.NationalNo;
            this.FirstName = UserPersonal.FirstName;
            this.SecondName = UserPersonal.FirstName;
            this.ThirdName = UserPersonal.LastName;
            this.LastName = UserPersonal.LastName;
            this.DateOfBirth = UserPersonal.DateOfBirth;
            this.Gendor = UserPersonal.Gendor;
            this.Address = UserPersonal.Address;
            this.Phone = UserPersonal.Phone;
            this.Email = UserPersonal.Email;
            this.NationalityCountryID = UserPersonal.NationalityCountryID;
            this.ImagePath = UserPersonal.ImagePath;
            Mode = enMode.Update;
        }

        public enum enMode { AddNew = 0, Update = 1 };

        public enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
        public bool IsActive { get; set; }
       


        private bool AddNewUser()
        {

            if (clsUser.Find(this.UserName, this.Password) != null)
            {
                return false;
            }

            this.Password = clsPasswordSecurity.ComputeHash(this.Password);

            this.UserID = clsUsers.AddUser(this.PersonID, this.UserName, this.Password, this.IsActive);

            return this.UserID  != 0;
        }

        private bool UpdateUser()
        {
            if (clsUser.Find(this.UserName, this.Password) != null && clsUser.Find(this.UserName, this.Password).UserID != this.UserID)
            {
                return false;
            }

            this.Password = clsPasswordSecurity.ComputeHash(this.Password);

            return clsUsers.UpdateUser(UserID, PersonID, UserName, Password, IsActive);
        }

        public static DataTable GetAllUsers()
        {
            DataTable Users = clsUsers.GetAllUsers();
            return Users;
        }

        public static DataTable GetAllUsersOrderByColumn(string textLike, string Column)
        {
            DataTable Users = clsUsers.GetAllUsersOrderByColumn(textLike, Column);
            return Users;
        }

        public static clsUser Find(int UserID)
        {

            int PersonID = -1;
            string UserName = string.Empty;
            string Password = string.Empty;           
            bool IsActive = false;


            if (clsUsers.FindUserByID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);



            return null;

        }

        public static clsUser Find(string UserName, string Password)
        {

            int PersonID = -1;
            int UserID = -1;
            bool IsActive = false;


            if (clsUsers.FindUserByUserNameAndPassword( ref UserID, ref PersonID, UserName, clsPasswordSecurity.ComputeHash(Password), ref IsActive))
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);

            return null;

        }

        public static bool DeleteUserByID(int UserID)
        {
            return clsUsers.DeleteUserByID(UserID);
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    break;

                case enMode.Update:
                    return UpdateUser();

                    break;

            }
            return false;

        }

        public static bool IsPersonInUsersSystem(int PersonID)
        {

            foreach (DataRow Row in GetAllUsers().Rows)
            {
                if (Row["PersonID"].ToString() == PersonID.ToString()) return true;
            }

            return false;
        }

    }
}
