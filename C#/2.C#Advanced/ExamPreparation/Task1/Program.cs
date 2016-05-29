using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            string[] AlienDigits = {"LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON"};

            int[] digits = new int[32];
            int digitCount = 0;
            do
            {
                digits[digitCount] = (int)(number % 9);
                number /= 9;
                digitCount++;
            }
            while (number > 0);

                for (int i = digitCount - 1; i >= 0; i--)
            {
                Console.Write(AlienDigits[digits[i]]);
            }
            Console.WriteLine();


        }
    }
}
