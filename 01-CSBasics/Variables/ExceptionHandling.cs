using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class ExceptionHandling
    {
        static public void ThreeExptions()
        {
            Console.WriteLine("Enter Your Age: ");

            // #1 program crushing on wrong input
            //int nAge = Convert.ToInt32(Console.ReadLine());


            // #2 program never crushing
            //int aAge = 0;
            //bool isInt = int.TryParse(Console.ReadLine(), out aAge);
            //Console.WriteLine(isInt);

            //3 program show an exception
            try {
                int nAge = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex) { 
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        }
    }
}
