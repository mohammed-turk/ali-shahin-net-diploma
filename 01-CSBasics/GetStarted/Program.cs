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
            Console.ReadKey();
            GetStarted.SubNamespace1.Class1 obj = new GetStarted.SubNamespace1.Class1();
            Console.WriteLine();
            obj.Method1();
        }
    }
}
