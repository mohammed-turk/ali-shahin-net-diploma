using System.Collections;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ArraysDeclarings();
            //GetMaxValueFromArray();
            //DuplicatesWithForEach();
            //ArrayReverse();
            DimensionalArrays();
        }

        static void ArraysDeclarings()
        {
            int[] a1 = new int[] { 1, 2, 3 };

            int[] a2 = new int[3];
            a2[0] = 1;
            a2[1] = 2;
            a2[2] = 3;

            int[] a3 = new int[3];
            for (int i = 0; i < a3.Length; i++)
            {
                a3[i] = a1[i];
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"a1 of {i} is {a1[i]}");
                Console.WriteLine($"a2 of {i} is {a2[i]}");
                Console.WriteLine($"a3 of {i} is {a3[i]}");
            }


        }

        static void GetMaxValueFromArray()
        {
            Console.WriteLine("welcome to the max value on the array application");

            Console.WriteLine("Ente the array size: ");
            int nArraySize = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[nArraySize];
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"Enter the value of index {i}: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr1[0];
            for (int i = 1; i < arr1.Length; i++)
            {
                if (max < arr1[i])
                {
                    max = arr1[i];
                }
            }
            Console.WriteLine($"max value is: {max}");
        }
        static void DuplicatesWithForEach()
        {
            int[] arr1 = { 1, 2, 2, 3, 2 };
            int countDuplicates = 0;


            foreach (int number in arr1)
            {
                if (number == 2)
                    countDuplicates++;
            }

            Console.WriteLine("2 has " + countDuplicates + " duplicates");

        }

        static void ArrayReverse()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] temp = new int[5];
            int count = 0;

            // choosed for instead of forEach as we need a counter
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                temp[i] = arr1[count];
                count++;
            }
            arr1 = temp;
            Console.Write("Array in reverse is: ");
            foreach (int number in arr1)
            {
                Console.Write(number);
            }

            //microsoft easy method:
            int[] arr2 = { 1, 2, 3, 4, 5 };
            int[] temp2 = new int[6];
            arr2.CopyTo(temp2, 1);
            Console.WriteLine();
            Console.WriteLine("CopyTo method for arrays");
            Console.Write("Array 2 is: ");
            foreach (int number in arr2)
            {
                Console.Write(number);
            }

            Console.WriteLine();
            Console.Write("temp 2 is: ");
            foreach (int number in temp2)
            {
                Console.Write(number);
            }

        }
        static void ArrayMethods()
        {
            // do not use them untill you reach asp.net
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Array.Clear(arr1);
            Console.WriteLine();
            arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int x = Array.Find(arr1, a => a == 2);
            int[] y = Array.FindAll(arr1, a => a == 3);
            var z = Array.FindAll(arr1, a => a == 4);

            int[] arr2 = (int[])arr1.Clone();
            Array.Sort(arr2);
            Array.Reverse(arr2);
            Console.WriteLine();


        }

        static void DimensionalArrays()
        {
            int[] oneDim = new int[2] { 1, 2 };
            oneDim[0] = 5;

            int[,] twoDim = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            twoDim[0, 0] = 5;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    twoDim[i, j] = i + j;
                    Console.Write(twoDim[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,,] threeDim = new int[2, 3, 2] { { { 1, 2 }, { 3, 4 }, { 5, 6 } }, { { 7, 8 }, { 9, 10 }, { 11, 12 } } };
            threeDim[0, 0, 0] = 5;
        }

    }
}
