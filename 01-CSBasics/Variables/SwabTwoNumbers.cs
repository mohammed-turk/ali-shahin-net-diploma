using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class SwabTwoNumbers
    {

        static public void SwabTwoNumbersMethod()
        {
            Console.WriteLine("Enter the first number:");
            int nFirstNumber = 0;
            bool isValidFirstNumber = int.TryParse(Console.ReadLine(), out nFirstNumber);
            int nSecondNumber = 0;
           Console.WriteLine("Enter the second number:");
            bool isValidSecondNumber =  int.TryParse(Console.ReadLine(), out nSecondNumber);

            int nTemp = 0;
            nTemp = nFirstNumber;
            nFirstNumber = nSecondNumber;
            nSecondNumber = nTemp;

            Console.WriteLine("After swabbing the two numbers: first is " + nFirstNumber + " and second is " + nSecondNumber);
           




        }
    }
}
