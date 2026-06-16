namespace Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* statements:
             * single statements (declerating vars, method calling, expresion) and ended with ;
             * compound statements (enclused by {} and has single stats inside)
             * control statements (conditions, loops, jumb, and exception handling)
             */

            // relational operators return boolean values (true or false) and include : ==, !=, >, <, >=, <=.

            //ArthmeticOperators();
            RelationalOperators();

        }

        static void ArthmeticOperators()
        {
            // arithmetic operators include: +, -, *, /, %, ++, --.
            int a = 10;
            int b = 3;
            int sum = a + b; // addition
            int difference = a - b; // subtraction
            int product = a * b; // multiplication
            int quotient = a / b; // division
            int remainder = a % b; // modulus
            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");
        }

        static void RelationalOperators()
        {
            Console.WriteLine("5 < 10 is " + (5 < 10));
            Console.WriteLine("5 > 10 is " + (5 > 10));
            Console.WriteLine("5 <= 10 is " + (5 <= 10));
            Console.WriteLine("5 >= 10 is " + (5 >= 10));
            Console.WriteLine("5 == 10 is " + (5 == 10));
            Console.WriteLine("5 != 10 is " + (5 != 10));
        }
    }
}
