using System;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void CheckIfBIgger(int[] numbers)
        {
            int counter = 0;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(' ');
            int[] numbers = Array.ConvertAll<string, int>(numbersStr, int.Parse);
            CheckIfBIgger(numbers);
        }
    }
}
