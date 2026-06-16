using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class YearsToDays
    {
        static public void ConvertYearsToDays()
        {
            Console.WriteLine("Enter the number of years:");
            int nYears = 0;
            bool isValidYears = int.TryParse(Console.ReadLine(), out nYears);
                        if (!isValidYears)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the years.");
            }
            else if (nYears < 0)
            {
                Console.WriteLine("Years cannot be negative. Please enter a non-negative number.");
            }
            else
            {
                var yearsCalculations = new { 
                 nMonths = nYears * 12,
                 nWeaks = nYears * 52,
                 nHours = nYears * 365 * 24,
                 nDays = nYears * 365
                };
                 // This does not account for leap years, but it's a common approximation.
                Console.WriteLine($"{nYears} years is {yearsCalculations.nMonths} months, {yearsCalculations.nWeaks} weeks, and {yearsCalculations.nDays} days.");
            }
        }
    }
}
