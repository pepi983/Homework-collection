using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());
            BigInteger Nfact = 1;
            BigInteger Kfact = 1;
            for (BigInteger i = 1; i <= N; i++)
            {
                Nfact *= i;
            }
            for (BigInteger j = 1; j <= K; j++)
            {
                Kfact *= j;
            }
            BigInteger result = Nfact / Kfact;
            Console.WriteLine(result);


        }
    }
}
