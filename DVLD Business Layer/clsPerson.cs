using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Data_Access_Layer;

namespace DVLD_Business_Layer
{
    public class clsPerson
    {
        public clsPerson()
        {

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
        public clsPerson
            (int PersonID, string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, int Gendor
            , string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }

        public enum enMode { AddNew = 0, Update = 1 };

        public enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + SecondName + " " + ThirdName + " " + LastName;
            }
        }
        public DateTime DateOfBirth { get; set; }

        //When Gendor = 0 Then He is Male, Other Else Then She Is Female
        public int Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        private bool AddNewPerson()
        {
            this.PersonID = clsPeople.AddPerson(NationalNo, FirstName, SecondName,
            ThirdName, LastName, DateOfBirth, Gendor
            , Address, Phone, Email, NationalityCountryID, ImagePath);

            return PersonID != -1;
        }
        private bool UpdatePerson()
        {
            return clsPeople.UpdatePerson(PersonID, NationalNo, FirstName, SecondName,
            ThirdName, LastName, DateOfBirth, Gendor
            , Address, Phone, Email, NationalityCountryID, ImagePath);
        }




        public static DataTable GetAllPeople()
        {
            return clsPeople.GetAllPeople();
        }

        public static DataTable GetAllPeopleOrderByColumn(string textLike, string Column)
        {
            return clsPeople.GetAllPeopleOrderByColumn(textLike, Column);
        }
        public static clsPerson Find(int PersonID)
        {
            string NationalNo = string.Empty;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            int Gendor = -1;
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            int NationalityCountryID = -1;
            string ImagePath = string.Empty;

            if (clsPeople.FindPersonByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName
                , ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName
                , DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);


            return null;

        }

        public static clsPerson Find(string NationalNo)
        {

            int PersonID = -1;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            int Gendor = -1;
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            int NationalityCountryID = -1;
            string ImagePath = string.Empty;

            if (clsPeople.FindPersonByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName
                , ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName
                , DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);


            return null;

        }

        public static bool DeletePersonByID(int PersonID)
        {
            return clsPeople.DeletePersonByID(PersonID);
        }


        public static DataTable GetAllCountries()
        {
            return clsPeople.GetAllCountries();
        }

        public static string GetCountryNameByCountryID(int ID)
        {
            return clsPeople.GetCountryNameByCountryID((int)ID);
        }

        public static int GetCountryIDByCountryName(string CountryName)
        {
            return clsPeople.GetCountryIDByCountryName(CountryName);
        }
        public static bool IsHasNationalNo(string NationalNo)
        {
            DataTable People = clsPeople.GetAllPeople();
            foreach (DataRow Row in People.Rows)
            {
                if (NationalNo.ToString() == Row["NationalNo"].ToString()) return true;
            }
            return false;
        }
        public bool Save()
        {
            if (clsPerson.IsHasNationalNo(this.NationalNo) && clsPerson.Find(this.PersonID) == null) return false;

            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewPerson())
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
                    return UpdatePerson();

                    break;

            }
            return false;

        }
        public static bool IsValidEmail(string Email)
        {

            if (!Email.Contains("@") || !Email.Contains(".com") || Email[0] == '@' || Email[Email.Length - 1] == '@') return false;

            byte @Numbers = 0, ComNumbers = 0;
            bool IsReachedToAt = false;

            for (int i = 0; i < Email.Length; i++)
            {

                if (Email[i] == '.' && !IsReachedToAt) return false;

                if (Email[i] == '@')
                {

                    IsReachedToAt = true;
                    @Numbers++;
                }
                if (Email[i] == '.') ComNumbers++;

                if (Email[i] == '@' && i + 1 < Email.Length && Email[i + 1] == '.') return false;
                if (@Numbers > 1 || ComNumbers > 1) return false;

            }

            return true;
        }
    }

}

