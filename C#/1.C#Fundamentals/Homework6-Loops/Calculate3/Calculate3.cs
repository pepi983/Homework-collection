using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int shit3 = N - K;
            BigInteger Nfact = 1;
            BigInteger Kfact = 1;
            BigInteger Shitfact = 1;
            for (int i = 1; i <= N; i++)
            {
                Nfact *= i;
            }
            for (int j = 1; j <= K; j++)
            {
                Kfact *= j;
            }
            for (int k = 1; k <= shit3; k++)
            {
                Shitfact *= k;
            }
            BigInteger result = Nfact / (Kfact * Shitfact);
            Console.WriteLine(result);

        }
    }
}
