using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cages = new int[200];
            string currCage = Console.ReadLine();
            int n = 0;

            while (currCage != "END")
            {
                cages[n] = int.Parse(currCage);
                n++;
                currCage = Console.ReadLine();
            }

            for (int i = 1; i <= n; i++)
            {

                int s = 0;

                for (int j = 0; j < i; j++)
                {
                    s += cages[j];
                }

                if (n - i < s)
                {
                    break;
                }

                int sum = 0;
                BigInteger product = 1;

                for (int j = i; j < i + s; j++)
                {
                    sum += cages[j];
                    product *= cages[j];
                }

                string next = sum.ToString() + product.ToString();

                for (int j = i + s; j < n; j++)
                {
                    next += cages[j].ToString();
                }

                next = next.Replace("0", "");
                next = next.Replace("1", "");

                n = next.Length;

                for (int j = 0; j < n; j++)
                {
                    cages[j] = next[j] - '0';
                }


            }

            Console.WriteLine(string.Join(" ", cages.Select(x => x.ToString()).ToArray(), 0, n));
        }
    }
}