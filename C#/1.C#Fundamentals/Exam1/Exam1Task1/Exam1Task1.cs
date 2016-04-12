using System;

namespace Exam1Task1
{
    class Exam1Task1
    {
        static void Main()
        {
            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());
            double arithmetic = ((A + B + C) / 3.0);
            long Max1 = Math.Max(A, B);
            long Max2 = Math.Max(Max1, C);
            long Min1 = Math.Min(A, B);
            long Min2 = Math.Min(Min1, C);
            if (Max1 > Max2)
            {
                Console.WriteLine(Max1);
            }
            else
            {
                Console.WriteLine(Max2);
            }
            if (Min1 < Min2)
            {
                Console.WriteLine(Min1);
            }
            else
            {
                Console.WriteLine(Min2);
            }
            Console.WriteLine("{0:F2}", arithmetic);
        }
    }
}
