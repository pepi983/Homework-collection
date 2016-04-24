using System;

namespace GCD
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
            {
                Console.WriteLine(b);
            }

            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
