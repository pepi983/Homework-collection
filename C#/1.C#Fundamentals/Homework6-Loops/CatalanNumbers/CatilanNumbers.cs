using System;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int shit1 = 2 * N;
            int shit2 = N + 1;
            BigInteger Nfact = 1;
            BigInteger Kfact = 1;
            BigInteger Shitfact = 1;
            for (int i = 1; i <= N; i++)
            {
                Nfact *= i;
            }
            for (int j = 1; j <= shit1; j++)
            {
                Kfact *= j;
            }
            for (int k = 1; k <= shit2; k++)
            {
                Shitfact *= k;
            }
            BigInteger result = Kfact / (Shitfact * Nfact);
            Console.WriteLine(result);

        }
    }
}
