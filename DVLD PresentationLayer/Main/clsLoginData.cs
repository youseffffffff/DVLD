using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DVLD_Business_Layer
{
    public class clsLoginData
    {
        private static string keyPath
        {
            get
            {
                return @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
            }
        }

        private static string NameDataForUserName
        {
            get
            {
                return "UserName";
            }
        }
        private static string NameDataForPassword
        {
            get
            {
                return "Password";
            }
        }


        public static bool GetValue(ref string UserName, ref string Password)
        {
            try
            {
                UserName = Registry.GetValue(keyPath, NameDataForUserName, null) as string;
                Password = Registry.GetValue(keyPath, NameDataForPassword, null) as string;
                
                
                if (UserName != null && UserName != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        public static bool SetValue(string UserName, string Password)
        {
            try
            {
                Registry.SetValue(keyPath, NameDataForUserName, UserName, RegistryValueKind.String);
                Registry.SetValue(keyPath, NameDataForPassword, Password, RegistryValueKind.String);


                return true;
            }
            catch
            {
                return false;
            }
        }


        public static bool DeleteValue()
        {
            string keyPath = @"SOFTWARE\YourSoftware";

            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                    {
                        if (key != null)
                        {
                            // Delete the specified value
                            key.DeleteValue(NameDataForUserName);
                            key.DeleteValue(NameDataForPassword);

                            return true;
                         
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}
