using System;

namespace Exam1Task1
{
    class Exam1Task1
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int Max1 = Math.Max(a, b);
            int Max2 = Math.Max(Max1, c);
            int Max = Math.Max(Max1, Max2);
            int Min1 = Math.Min(a, b);
            int Min2 = Math.Min(Min1, c);
            int Min = Math.Min(Min1, Min2);
            int arithmetic = (a + b + c) / 3;
            Console.WriteLine(Max);
            Console.WriteLine(Min);
            Console.WriteLine(arithmetic);

        }   

    }
}
