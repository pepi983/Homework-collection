using System;
using System.Numerics;

namespace IntegerCalculations
{
    class Program
    {
        static void GetMin(int[] numbers)
        {
            Array.Sort(numbers);
            Console.WriteLine(numbers[0]);
        }
        static void GetMax(int[] numbers)
        {
            Array.Sort(numbers);
            Console.WriteLine(numbers[4]);
        }
        static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];
            }
            double average = sum / 5.0;
            Console.WriteLine("{0:F2}", average);
        }
        static void GetSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
        static void GetProduct(int[] numbers)
        {
            BigInteger product = 1;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                product *= numbers[i];
            }
            Console.WriteLine(product);
        }

        static void Main(string[] args)
        {
            string inputA = Console.ReadLine();
            string[] nums = inputA.Split(' ');
            int[] numbers = Array.ConvertAll<string, int>(nums, int.Parse);
            GetMin(numbers);
            GetMax(numbers);
            GetAverage(numbers);
            GetSum(numbers);
            GetProduct(numbers);
        }
    }
}
