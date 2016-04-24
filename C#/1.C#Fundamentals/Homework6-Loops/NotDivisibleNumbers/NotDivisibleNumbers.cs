using System;

namespace NumbersFrom1ToN
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i <= N; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
