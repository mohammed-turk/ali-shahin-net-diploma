using System.Text;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verpatent strings, igonres all special chars exccept the "
            Console.WriteLine(@"Hello,"" World!

hi");


            // C# verpatnt row strings
            // hepfull for blocks on the html elements
            Console.WriteLine(""""
                 1
                5
                6
                
                 
                
                """");

            Console.WriteLine(@$"hi
how are you");

            // for inner vars
            Console.WriteLine($""""
                 1
                5
                6
                {1}
                 
                
                """");

            // array to string == join
            string[] arr1 = new string[] { "Hello", "World", "!" };
            string newstring = string.Join(" ", arr1);
            Console.WriteLine(newstring);

            //strings methods
            string phase = "a developer can work under the pressure on all times";
            foreach(int num in phase)
            {
                if (num == ' ')
                {
                    Console.WriteLine("found space");
                    //num = '-'; wrong!
                }
            }
            char[] phsaseArray = phase.ToArray();
            //for (int i = 0; i < phsaseArray.Length; i++)
            //{
            //    if (phsaseArray[i] == ' ')
            //    {
            //        phsaseArray[i] = '-';
            //    }
            //}
            phase = phsaseArray.ToString(); // wrong! ToString() will return the type name, not the string representation of the array.
            phase = new string(phsaseArray); // this is the correct way to convert a char array back to a string.
            Console.WriteLine(phase);
            int index = phase.IndexOf("pressure");

            int lastIndex = phase.LastIndexOf("pressure");
            bool contains = phase.Contains("pressure");
            bool startsWith = phase.StartsWith("a developer");
            bool endsWith = phase.EndsWith("times");
            phase = phase.Replace("pressure", "stress");
            phase = phase.ToUpper();
            string[] newPhase = phase.Split(" ");
            foreach(string n in newPhase)
                Console.WriteLine(n);
            string jasonArray = "{first = 'error'},{first = 'error'}}";
            string[] splittedJason = jasonArray.Split(",");
            string suBstring = phase.Substring(phase.IndexOf(" "), 10);

            string word = "1-5/2-7/3-9#1-3/2-8/3-8#1-5/2-8/3-8";
            string[] byStudents = word.Split("#");
            string[][] bySubjects= new string[byStudents.Length][];
            for (int i = 0; i < byStudents.Length; i++)
            {
                bySubjects[i] = byStudents[i].Split('/');
            }
            
            foreach (string[] n in bySubjects)
            {

                Console.WriteLine($"Student {Array.IndexOf(bySubjects, n) + 1}:");
                foreach (string m in n)
                {
                    Console.WriteLine(m.Replace('-', ' '));
                    
                }
                Console.WriteLine("-------------");
            }
            Console.WriteLine("Enter a word: ");
            string inputWord = Console.ReadLine();
            bool isPalindrome = true;
            //for (int i = 0; i < inputWord.Length / 2; i++)
            //{
            //    if (inputWord[i] != inputWord[inputWord.Length - 1 - i])
            //    {
            //        Console.WriteLine("The word is not a palindrome.");
            //        isPalindrome = false;
            //        return;
            //    }
            //}
            //if (isPalindrome) { 
            // Console.WriteLine("The word is a palindrome.");
            //}

            // string builder for concatenation without ruining the memory {adaptive string instead of new string for every change}
            // it is linked in data structure
            StringBuilder myString = new StringBuilder(100);
            myString.AppendLine("Hello world");
            myString.Append("Hello world");
            Console.WriteLine(myString.ToString()); 
            Console.WriteLine(myString.Length);
            Console.WriteLine(myString.MaxCapacity);
            Console.WriteLine(myString.Capacity);


        }
       



    }
}
