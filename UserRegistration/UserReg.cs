﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class UserReg
    {
        public static void ValidateFirstName()
        {
            Console.WriteLine("Please Enter your First Name:");
            Console.WriteLine("Note: First name starts with Cap and has minimun 3 characters");
            string firstName = Console.ReadLine();
            string firstName_pattern = "^[A-Z][aA-zZ]{2,15}$";

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
    }
}