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

            /* C# precedance of operators (from highest to lowest):
             * 0. member access (.), method call (), and array indexing [] operators
             * 1. Parentheses ()
             * 2. Unary operators (++, --, (signs + and -), !)
             * 3. Multiplicative operators (*, /, %)
             * 4. Additive operators (+, -)
             * 5. Relational operators (<, >, <=, >=)
             * 6. Equality operators (==, !=)
             * x. &
             * x. ^
             * x. | (bitwise operators, opposite is true if both are true and false if both are false)
             * 7. Logical AND (&&)
             * 8. Logical OR (||)
             * 9. Assignment operators (=, +=, -=, etc.)
             */

            /*
             * sizeof(double)
             * typeof(Program)
             * 
             */
            Console.WriteLine("Size of double is: " + sizeof(double));
            Console.WriteLine("type of Console is: " + typeof(Console));
            object obj = 4;
            bool isInt = obj is int; // true, because obj is an int
            bool isLong = obj is long;

            //as only with referance types eccept if you make the value type nullable.
            // as if it couldn't convert then it return null without exception
            string str = obj as string;
            // relational operators return boolean values (true or false) and include : ==, !=, >, <, >=, <=.

            //ArthmeticOperators();
            //RelationalOperators();
            //LogicalOperators();
            //StudentGrades();
            //Taxes();
            NumerClassification();

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

        static void LogicalOperators()
        {
            // logical operators include: && (logical AND), || (logical OR), ! (logical NOT), ^ (logical XOR, opposite is true and same is false).
            bool a = true;
            bool b = false;
            Console.WriteLine($"a && b: {a && b}"); // false
            Console.WriteLine($"a || b: {a || b}"); // true
            Console.WriteLine($"a || b: {a ^ b}"); // true n
            Console.WriteLine($"!a: {!a}"); // false
            Console.WriteLine($"!b: {!b}"); // true


            // && and || are better than | and & as they shortened the evaluation which help in performance.
        }

        static void StudentGrades()
        {

            Console.WriteLine("Enter your grade:");
            int grade = Convert.ToInt32(Console.ReadLine());
            if (grade >= 95 && grade <= 100)
            {
                Console.WriteLine("You got A+");
            }
            else if (grade >= 90 && grade < 95)
            {
                Console.WriteLine("You got A");
            }
            else if (grade >= 85 && grade < 90)
            {
                Console.WriteLine("You got B+");
            }
            else if (grade >= 80 && grade < 85)
            {
                Console.WriteLine("You got B");
            }
            else if (grade >= 75 && grade < 80)
            {
                Console.WriteLine("You got C+");
            }
            else if (grade >= 70 && grade < 75)
            {
                Console.WriteLine("You got C");
            }
            else if (grade >= 65 && grade < 70)
            {
                Console.WriteLine("You got D+");
            }
            else if (grade >= 60 && grade < 65)
            {
                Console.WriteLine("You got D");
            }
            else if (grade >= 0 && grade < 60)
            {
                Console.WriteLine("You got F");
            }
            else
            {
                Console.WriteLine("Grade value should be between 0 and 100");

            }
        }

        static void Taxes()
        {
            //Console.WriteLine("Enter your income: ");
            //double nIncome = 0;
            //bool nIsValid = double.TryParse(Console.ReadLine(), out nIncome);

            //if (nIsValid)
            //{
            //    Console.WriteLine("Enter 1 if you are an employee or 2 if you are a buisness man: ");
            //    int ntype = 0;
            //    bool isValidType = int.TryParse(Console.ReadLine(), out ntype);

            //    if (isValidType) {
            //        if (nIncome <= 10000 && nIncome > 0)
            //        {
            //            Console.WriteLine("Your taxes is 1000");

            //        }
            //        else { 
            //            Console.WriteLine("Your taxes is: " + nIncome*0.20);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter 1 for employee");
            //    }

            //    }
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number for the income.");
            //}

            // short hand if
            Console.WriteLine("Enter your income: ");
            double nIncome = 0;
            bool nIsValid = double.TryParse(Console.ReadLine(), out nIncome);
            Console.WriteLine("Enter 1 if you are an employee or 2 if you are a buisness man: ");
            int ntype = 0;
            bool isValidType = int.TryParse(Console.ReadLine(), out ntype);

            double takes = (nIncome <10000)? 0: ( ntype == 1) ? 1000 : nIncome * 0.20;

            Console.WriteLine("Your taxes is: " + takes);

        }
        static void NumerClassification()
        {
            Console.WriteLine("Enter a number: ");
            int nNumber = Convert.ToInt32(Console.ReadLine());
            string classification = (nNumber <0 ) ? "Negative" : (nNumber > 0) ? "Positive" : "Zero";
            Console.WriteLine("The number is: " + classification);
        }
    }
}
