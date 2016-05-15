using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void AddArrays(int[] arr1, int[] arr2)
        {
            
            int minlenght = Math.Min(arr1.Length, arr2.Length);
            int maxlenght = Math.Max(arr1.Length, arr2.Length);
            int[] result = new int[maxlenght];
            bool isBigger = false;
            if (arr1.Length > arr2.Length)
            {
                isBigger = true;
            }
            for (int i = 0; i < minlenght; i++)
            {
                result[i] = arr1[i] + arr2[i];
            }
            for (int k = minlenght; k < maxlenght; k++)
            {
                if (isBigger)
                {
                    result[k] += arr1[k];
                }
                else
                {
                    result[k] += arr2[k];
                }
            }
            for (int j = 0; j < maxlenght; j++)
            {
                if (result[j] >= 10)
                {
                    result[j] -= 10;
                    result[j + 1] += 1;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string[] sizeArr = size.Split(' ');
            int[] sizeIntArr = Array.ConvertAll<string, int>(sizeArr, int.Parse);
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();
            string[] inputtedA = inputA.Split(' ');
            string[] inputtedB = inputB.Split(' ');
            int[] numberA = Array.ConvertAll<string, int>(inputtedA, int.Parse);
            int[] numberB = Array.ConvertAll<string, int>(inputtedB, int.Parse);
            AddArrays(numberA, numberB);
        }
    }
}
