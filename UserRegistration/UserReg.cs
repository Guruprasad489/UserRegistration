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
        //UC1
        public static void ValidateFirstName()
        {
            Console.WriteLine("\nPlease Enter your First Name:");
            Console.WriteLine("Note: First name starts with Cap and has minimun 3 characters");
            string firstName = Console.ReadLine();
            string firstName_pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(firstName, firstName_pattern))
            {
                Console.WriteLine("First Name is Valid");
            }
            else
            {
                Console.WriteLine("First Name is not Valid");
                ValidateFirstName();
            }
        }

        //UC2
        public static void ValidateLastName()
        {
            Console.WriteLine("\nPlease Enter your Last Name:");
            Console.WriteLine("Note: Last name starts with Cap and has minimun 3 characters");
            string lastName = Console.ReadLine();
            string lastName_pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(lastName, lastName_pattern))
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Last Name is not Valid");
                ValidateLastName();
            }
        }

        //UC3
        public static void ValidateEmail()
        {
            Console.WriteLine("\nPlease Enter your Email-ID:");
            Console.WriteLine("Note: E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional (xyz & in) with precise @ and . positions");
            string email = Console.ReadLine();
            string email_pattern = @"^[a-zA-Z0-9]{3,10}([._+-][a-zA-Z0-9]{1,10})?@[a-zA-Z0-9]{1,10}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

            if (Regex.IsMatch(email, email_pattern))
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Email is not Valid");
                ValidateEmail();
            }
        }

        //UC4
        public static void ValidateMobileNumber()
        {
            Console.WriteLine("\nPlease Enter your Mobie Number:");
            Console.WriteLine("Note: Country code follow by space and 10 digit number");
            string mobNum = Console.ReadLine();
            string mobNum_pattern = "^[+]?91[ -][1-9][0-9]{9}$";

            if (Regex.IsMatch(mobNum, mobNum_pattern))
            {
                Console.WriteLine("Mobie Number is Valid");
            }
            else
            {
                Console.WriteLine("Mobie Number is not Valid");
                ValidateMobileNumber();
            }
        }

        //UC5, UC6
        public static void ValidatePassword()
        {
            Console.WriteLine("\nPlease Enter your Password:");
            Console.WriteLine("Note: Password must contain min 8 characters");
            string password = Console.ReadLine();
            string password_pattern = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";

            if (Regex.IsMatch(password, password_pattern))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is not Valid");
                ValidatePassword();
            }
        }
    }
}
