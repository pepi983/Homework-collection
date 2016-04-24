using System;
class TrailingZero
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counterZeroes = 0;
        int divider = 5;

        while (n / divider >= 1)
        {
            counterZeroes += n / divider;
            divider *= 5;
        }

        Console.WriteLine(counterZeroes);
    }
}