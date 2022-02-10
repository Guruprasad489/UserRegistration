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

            UserReg.ValidateFirstName();

            Console.ReadLine();
        }
    }
}
