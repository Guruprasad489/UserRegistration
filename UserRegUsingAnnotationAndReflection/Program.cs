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
            Console.WriteLine("Welcome to user registration with reflection and annotation program");

            ValidateUserReg UserReg = new ValidateUserReg();
            UserReg.vaidateUser();
            Console.ReadLine();
        }
    }
}
