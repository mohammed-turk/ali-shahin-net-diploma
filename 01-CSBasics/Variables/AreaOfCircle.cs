using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class AreaOfCircle
    {
        static public void CalculateAreaOfCircle()
        {
            //double radius = 5.0;
            //double area = Math.PI * radius * radius;
            //Console.WriteLine($"The area of the circle with radius {radius} is {area}");
            double radius = 0.0;
            bool isValidRedius = double.TryParse(Console.ReadLine(), out radius);

            Console.WriteLine("Enter the radius of the circle in cm:");
            if (!isValidRedius)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for the radius.");
            }
            else if (radius < 0)
            {
                Console.WriteLine("Radius cannot be negative. Please enter a non-negative number.");
            }
            else
            {
                double area = Math.PI * radius * radius;
                Console.WriteLine($"The area of the circle with radius {radius} cm is {area} square cm.");
                
            }

        }
    }
}
