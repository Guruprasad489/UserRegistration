using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserReg
    {
        //UC1 - Method to Validate First Name entered by user
        public static string ValidateFirstName(string firstName)
        {
            string firstName_pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(firstName, firstName_pattern))
            {
                Console.WriteLine("First Name is Valid");
                return firstName;
            }
            else
            {
                return "First Name is not Valid";
            }
        }

        //UC2 - Method to Validate Last Name entered by user
        public static string ValidateLastName(string lastName)
        {
            string lastName_pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(lastName, lastName_pattern))
            {
                Console.WriteLine("Last Name is Valid");
                return lastName;
            }
            else
            {
                return "Last Name is not Valid";
            }
        }

        //UC3 - Method to Validate Email-ID entered by user
        public static string ValidateEmail(string email)
        {
            string email_pattern = @"^[a-zA-Z0-9]{3,10}([._+-][a-zA-Z0-9]{1,10})?@[a-zA-Z0-9]{1,10}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

            if (Regex.IsMatch(email, email_pattern))
            {
                Console.WriteLine("Email is Valid");
                NLog.SuccessInfo("Email-ID is Valid: "+ email);
                return email;
            }
            else
            {
                NLog.ErrorInfo("Email-ID is not Valid: " + email);
                return "Email is not Valid";
            }
        }

        //UC4 - Method to Validate Mobile Number entered by user
        public static string ValidateMobileNumber(string mobNum)
        {
            string mobNum_pattern = "^[+]?91[ -][1-9][0-9]{9}$";

            if (Regex.IsMatch(mobNum, mobNum_pattern))
            {
                Console.WriteLine("Mobie Number is Valid");
                return mobNum;
            }
            else
            {
                return "Mobie Number is not Valid";
                
            }
        }

        //UC5, UC6, UC7, UC8  - Method to Validate Password entered by user
        public static string ValidatePassword(string password)
        {
            //string password_Pattern = "^[a-zA-Z]{8,}$";                                               //UC5: Password must contain min 8 characters
            //string password_pattern = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";                                //UC6: UC5 + atleast 1 Upper Case
            //string password_Pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";                     //UC7: UC6 + atleast 1 numeric number
            string password_Pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@?^*!~]).{8,}$";     //UC8: UC7 + 1 special character

            if (Regex.IsMatch(password, password_Pattern))
            {
                Console.WriteLine("Password is Valid");
                NLog.SuccessInfo("Password is Valid: " + password);
                return password;
            }
            else
            {
                NLog.ErrorInfo("Invalid Password: " + password);
                return "Password is not Valid";
            }
        }
    }
}
