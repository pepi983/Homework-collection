using System;

namespace SumOfInts
{
    class SumOfInts
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;
            string[] nums = input.Split(' ');
            int[] numbers = Array.ConvertAll<string, int>(nums, int.Parse);
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
