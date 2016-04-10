using System;

namespace ExchangeBits
{
    class BitExchange
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int position1 = 3;
            int position2 = 24;
            int mask1 = 7 << position1;
            int mask2 = 7 << position2;
            int GetBits1 = mask1 & number;
            int GetBits2 = mask2 & number;
            int exchange = ((number & ~mask1) & ~mask2);
            int mask3 = (GetBits1 >> position1) << position2;
            int mask4 = (GetBits2 >> position2) << position1;
            int result = (exchange | mask3 | mask4);
            Console.WriteLine(result);

        }
    }
}
