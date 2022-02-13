using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WElcome to User Registration Program using Regex\n");
            try
            {
                while (true)
                {
                    Console.WriteLine("Please choose an option to Validate:");
                    Console.WriteLine("\n1. First Name \n2. Last Name \n3. Email-ID \n4. Mobile Number \n5. Password \n6. Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("\nPlease Enter your First Name:");
                            Console.WriteLine("Note: First name starts with Cap and has minimun 3 characters");
                            string firstName = Console.ReadLine();
                            Console.WriteLine(UserReg.ValidateFirstName(firstName));
                            break;
                        case 2:
                            Console.WriteLine("\nPlease Enter your Last Name:");
                            Console.WriteLine("Note: Last name starts with Cap and has minimun 3 characters");
                            string lastName = Console.ReadLine();
                            Console.WriteLine(UserReg.ValidateLastName(lastName));
                            break;
                        case 3:
                            Console.WriteLine("\nPlease Enter your Email-ID:");
                            Console.WriteLine("Note: E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional (xyz & in) with precise @ and . positions");
                            string email = Console.ReadLine();
                            UserReg.ValidateEmail(email);
                            break;
                        case 4:
                            Console.WriteLine("\nPlease Enter your Mobie Number:");
                            Console.WriteLine("Note: Country code follow by space and 10 digit number");
                            string mobNum = Console.ReadLine();
                            UserReg.ValidateMobileNumber(mobNum);
                            break;
                        case 5:
                            Console.WriteLine("\nPlease Enter your Password:");
                            Console.WriteLine("Note: Password must contain min 8 characters, atleast 1 Upper Case, atleast 1 numeric number and 1 special character");
                            string password = Console.ReadLine();
                            UserReg.ValidatePassword(password);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please choose a valid option");
                            break;
                    }
                    Console.ReadLine();
                }
            }
            catch (NullReferenceException e)
            {

                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
