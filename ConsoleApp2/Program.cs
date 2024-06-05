using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[3];
            firstArray[0] = 1;
            firstArray[1] = 2;
            firstArray[2] = 3;

            int[] secondArray = new int[3];
            secondArray[0] = 4;
            secondArray[1] = 5;
            secondArray[2] = 6;

            int[] thirdArray = new int[firstArray.Length + secondArray.Length];
            Array.Copy(firstArray, thirdArray, firstArray.Length);
            Array.Copy(secondArray, 0, thirdArray, firstArray.Length, secondArray.Length);

            foreach (var element in thirdArray)
            {
                Console.Write(element);
            }

        }
    }
}
