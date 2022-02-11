﻿using System;
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

            Console.WriteLine("Please choose an option");
            Console.WriteLine("\n1. First Name \n2. Last Name \n3. Email-ID");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UserReg.ValidateFirstName();
                    break;
                case 2:
                    UserReg.ValidateLastName();
                    break;
                case 3:
                    UserReg.ValidateEmail();
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
