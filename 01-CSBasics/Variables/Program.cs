namespace Variables
{
    internal class Program
    {
        int x = 5; // this variable is accessible within the entire class
        static void Main(string[] args)
        {
            //int x = 5; // this variable is only accessible within this method, it is a local variable

            //// built in Variables

            ////numeric
            //Console.WriteLine("------ sbyte ---------");
            //sbyte num1 = -5;
            //Console.WriteLine(sbyte.MinValue);
            //Console.WriteLine(sbyte.MaxValue);

            //Console.WriteLine("------ byte ---------");
            //byte num2 = 5;
            //Console.WriteLine(byte.MinValue);
            //Console.WriteLine(byte.MaxValue);

            //Console.WriteLine("------ short ---------");
            //short num3 = 5;
            //Console.WriteLine(short.MinValue);
            //Console.WriteLine(short.MaxValue);

            //Console.WriteLine("------ ushort ---------");
            //ushort num4 = 5;
            //Console.WriteLine(ushort.MinValue);
            //Console.WriteLine(ushort.MaxValue);

            //Console.WriteLine("------ int ---------");
            //int num5 = 5;
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            //Console.WriteLine("------ uint ---------");
            //uint num6 = 5;
            //Console.WriteLine(uint.MinValue);
            //Console.WriteLine(uint.MaxValue);

            //Console.WriteLine("------ long ---------");
            //long num7 = 5;
            //Console.WriteLine(long.MinValue);
            //Console.WriteLine(long.MaxValue);

            //Console.WriteLine("------ ulong ---------");
            //ulong num8 = 5;
            //Console.WriteLine(ulong.MinValue);
            //Console.WriteLine(ulong.MaxValue);

            //Console.WriteLine("------ float ---------");
            //float num9 = 5f;
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.MaxValue);

            //Console.WriteLine("------ double ---------");
            //double num10 = 5d;
            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(double.MaxValue);

            //Console.WriteLine("------ decimal ---------");
            //decimal num11 = 5m;
            //Console.WriteLine(decimal.MinValue);
            //Console.WriteLine(decimal.MaxValue);

            //// logical
            //bool isTrue = true;
            ////char
            //char char1 = 'A';
            //// strings
            //string str1 = "Hello World";
            //// datatime
            //DateTime date1 = DateTime.Now;
            ////object
            //object obj1 = new object();

            //// start with these for variables naming and capatalized the next words:
            //// n for numbers
            //// b for boolean
            //// c for char
            //// s for string
            //// dt for datetime
            //// o for object

            //// implicitly typed variable, the compiler will determine the type based on the value assigned to it
            //var num12 = 5; // this will be an int, type determined with first initalization, after assigning a value, you can't change its type.
            //// var cannot be sent as method parameters while the object can be.
            //scoping();

            //// var can be initalized as annonymous user defined datatype.
            //var myVar = new { Name = "John", Age = 30 }; // this is an anonymous type with two properties: Name and Age
            //Console.WriteLine(myVar.Name); // output: John
            //Console.WriteLine(myVar.Age); // output: 30
            //// myVar.Name = "Jane"; // error: cannot modify the properties of an anonymous type, they are read-only

            //ValueType();
            //ReferanceType();
            //DynamicType();


            //PrintFullName.PrintingFullName();
            //SumTwoNumbers.SummingTwoNumbers();
            //ExceptionHandling.ThreeExptions();
            //AreaOfCircle.CalculateAreaOfCircle();
            //SwabTwoNumbers.SwabTwoNumbersMethod();
            //YearsToDays.ConvertYearsToDays();


        }

        static void scoping()
        {
            int x = 5; // this variable is only accessible within this method
            if (x > 0)
            {
                int y = 10; // this variable is only accessible within this block
                Console.WriteLine(x + y); // can access both x and y here
            }
            // Console.WriteLine(y); // error: y is not accessible here
        }

        static void ValueType()
        {
            int num1 = 1;
            int num2 = 2;
            num1 = num2;
            num1 = 3;
            Console.WriteLine(num1); // output: 3
            Console.WriteLine(num2);
        }

        static void ReferanceType()
        {

            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = arr1; // arr2 is now referencing the same array as arr1
            arr1[0] = 10; // changing the first element of the array through arr1
            Console.WriteLine(arr2[0]); // output: 10, because arr2 is referencing the same array as arr1

            int[] arr4 = new int[2];
            int[] arr3 = { 1, 2, 3 };
        }

        static void NullableValues()
        {
            // value types (all types except the classes, arraylist, strings, and the delegates) need to be nullable for allowing null values.
            Nullable<int> x = null;
            int? y = null; // this is a shorthand for Nullable<int>
            //int h = x + y //is wrong
            int? h = x + y; // this is correct
        }

        static void DynamicType()
        {
            object oMyObj = 5;
            Console.WriteLine(oMyObj.GetType()); // output: 5
            oMyObj = 'c';
            Console.WriteLine(oMyObj.GetType()); // output: c
            oMyObj = "Hello";
            Console.WriteLine(oMyObj.GetType());

            dynamic num11 = 5;
            Console.WriteLine(num11.GetType());
            num11 = 'c';
            Console.WriteLine(num11.GetType());
            num11 = "Hello";
            Console.WriteLine(num11.GetType());

            //dynamic vs object vs var
            // dynamic skiped on compiling and transleted on the run time
            // object sat its value on compilation time
            // both are allowing the type to be change
            // var allowing assign any type but don't allow its changes

            // performance wise var is the best then the object then the dynamic
        }


    }

    internal class SumTwoNumbers()
    {
        static public void SummingTwoNumbers()
        {
            Console.WriteLine("Welcome to the sum of two numbers application");

            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            num1 = (short) num1;
            num1 = byte.Parse(num1.ToString()); // parse accept string input only

            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Summation is " + (num1 + num2));
        }
    }
}
