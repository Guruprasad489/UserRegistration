using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegUsingAnnotationAndReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegUsingAnnotation user = new UserRegUsingAnnotation();

            //Reading input from the user for user registraton
            Console.Write("Enter your first name: ");
            user.FirstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            user.LastName = Console.ReadLine();
            Console.Write("Enter your email Id: ");
            user.EmailId = Console.ReadLine();
            Console.Write("Enter your phone Number: ");
            user.PhoneNum = Console.ReadLine();
            Console.Write("Enter your password: ");
            user.Password = Console.ReadLine();
            TestUserRegAnnotationFields(user);
            Console.ReadLine();
        }

        //Method to check the valid annotations 
        public static void TestUserRegAnnotationFields(UserRegUsingAnnotation user)
        {
            ValidationContext validationContext = new ValidationContext(user, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(user, validationContext, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Satisfied all validations for user registration");
            }
        }
    }
}
