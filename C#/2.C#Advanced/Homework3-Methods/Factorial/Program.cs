using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void CalculateFactorial(int n)
        {           
            int digit = 1;
            BigInteger result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= digit;
                digit++;
            }
            Console.WriteLine(result);
        }



        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            CalculateFactorial(N);
        }


    }
}
