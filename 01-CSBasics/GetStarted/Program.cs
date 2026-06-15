using GetStarted.SubNamespace1;

namespace GetStarted
{
    namespace SubNamespace1
    {
        public class Class1
        {
            public void Method1()
            {
                Console.WriteLine("Hello from SubNamespace1.Class1.Method1");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Console.ReadKey();
            GetStarted.SubNamespace1.Class1 obj = new GetStarted.SubNamespace1.Class1();
            Console.WriteLine();
            obj.Method1();

            // same class name but different usings, places, and opjects.c
            GetStarted.Class1 obj2 = new GetStarted.Class1();
            GetStarted.SubNamespace1.Class1 class1 = new GetStarted.SubNamespace1.Class1();
            GetStarted.classTest.Class1 class2 = new GetStarted.classTest.Class1();

            // input & output
            Console.WriteLine("Enter a name");
            string x = Console.ReadLine();
            Console.WriteLine("Hello " + x);


        }
    }
    public class Class1
    {
        public void Method1()
        {
            Console.WriteLine("Hello from GetStarted.Class1.Method1");
        }
    }
}
