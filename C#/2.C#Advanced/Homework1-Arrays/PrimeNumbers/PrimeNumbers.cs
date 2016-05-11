using System;

namespace SumOfKMembers
{
    class SumOfKNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N+1];
            bool isPrime = true;
            int maxPrime = 0;
            for (int l = 1; l <= N; l++)
            {
                numbers[l] = l;
                if (numbers[l] < 2)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= (int)Math.Sqrt(l); i++)
                    {
                        if (numbers[l] % i == 0)
                        {
                            isPrime = false;
                        }
                        else
                        {
                            maxPrime = numbers[l];
                        }

                    }
                }
            }
                          
            Console.WriteLine(maxPrime);
        }
    }
}