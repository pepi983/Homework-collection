using System;

namespace SumOfKMembers
{
    class SumOfKNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());                    
            }
            Array.Sort(numbers);
            for (int l = 0; l < K; l++)
            {
                sum += numbers[numbers.Length - 1 - l];
            }
            Console.WriteLine(sum);
        }
    }
}
