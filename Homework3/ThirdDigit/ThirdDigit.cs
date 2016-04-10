using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int thirdDigit = (N / 100) % 10;
            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + thirdDigit);
            }
        }
    }
}
