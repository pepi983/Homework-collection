using System;

namespace Exam1Problem1
{
    class Printing
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine()); 
            int S = int.Parse(Console.ReadLine());
            double P = double.Parse(Console.ReadLine());
            double result = ((N * S) / 500.0) * P;
            Console.WriteLine("{0:F2}", result);
        }
    }
}
