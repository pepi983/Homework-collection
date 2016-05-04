using System;

namespace ConsoleApplication1
{
    class AllocateArray
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] ints = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}
