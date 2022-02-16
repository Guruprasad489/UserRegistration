using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegUsingAnnotationAndReflection
{
    public class ValidateUserReg
    {
        private readonly UserRegUsingAnnotation userRegUsingAnnotation;
        public ValidateUserReg() 
        {
            // Default constructor
        }
        public ValidateUserReg(UserRegUsingAnnotation annotation)
        {
            this.userRegUsingAnnotation = annotation;
        }
        //Method to take user input value set fields using reflector
        public void vaidateUser()
        {
            //Reading input from the user for user registraton
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your email Id: ");
            string emailId = Console.ReadLine();
            Console.Write("Enter your phone Number: ");
            string phoneNum = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            
            UserRegReflector userReg = new UserRegReflector();
            userReg.Setproperty("FirstName", firstName);
            userReg.Setproperty("LastName", lastName);
            userReg.Setproperty("EmailId", emailId);
            userReg.Setproperty("PhoneNum", phoneNum);
            userReg.Setproperty("Password", password);

            userReg.InvokeMethod("CheckAnnotationProperties");
        }

        //Method to check annotations are valid or not
        public void CheckAnnotationProperties()
        {
            ValidationContext validationcontext = new ValidationContext(userRegUsingAnnotation, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(userRegUsingAnnotation, validationcontext, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
                }
            }
            else
                Console.WriteLine("Satisfied all validations for user registration");
        }
    }
}
