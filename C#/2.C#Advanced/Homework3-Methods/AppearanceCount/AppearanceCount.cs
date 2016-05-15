using System;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static void AppearanceCounter(int[] numbers, int number)
        {
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(' ');
            int[] numbers = Array.ConvertAll<string, int>(numbersStr, int.Parse);
            int number = int.Parse(Console.ReadLine());
            AppearanceCounter(numbers, number);
        }
    }
}
