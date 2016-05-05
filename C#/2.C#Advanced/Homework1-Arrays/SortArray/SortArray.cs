using System;

namespace SumOfKMembers
{
    class SumOfKNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            for (int l = 0; l < N; l++)
            {
                Console.WriteLine(numbers[l]); 
            }
        }
    }
}
