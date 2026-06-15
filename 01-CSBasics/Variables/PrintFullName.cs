using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class PrintFullName
    {
        static public void PrintingFullName() {
            Console.WriteLine("Welcome to the full name application");

            Console.WriteLine("Enter your first name:");
            string sFirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last name:");
            string sLastName = Console.ReadLine();
            Console.WriteLine("Hello, " + sFirstName + " " + sLastName);
        }
    }
}
