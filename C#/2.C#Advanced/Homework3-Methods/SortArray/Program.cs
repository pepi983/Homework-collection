using System;
namespace SortArray
{
    class Program
    {
        static void ReverseArray(int[] numbers)
        {
            Array.Reverse(numbers);
            Array.Sort(numbers);
            Console.WriteLine(String.Join(" ", numbers));
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            int[] numbers = Array.ConvertAll<string, int>(nums, int.Parse);
            ReverseArray(numbers);
        }
    }
}
