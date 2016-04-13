using System;

namespace Interval
{
    class Interval
    {
        static void Main()
        {
            int amount = 0;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (n > m)
            {
                for (int kur = (m +1) ; kur < n; kur++)
                {
                    if (kur % 5 == 0)
                    {
                        amount++;
                    }
                }
            }
            else
            {
                for (int packa = (n + 1); packa < m; packa++)
                {
                    if (packa % 5 == 0)
                    {
                        amount++;
                    }
                }
            }
            Console.WriteLine(amount);
        }
        }
}

