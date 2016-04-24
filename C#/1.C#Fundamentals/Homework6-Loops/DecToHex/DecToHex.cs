using System;

namespace DecToHex
{
    class DecToHex
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine("{0:X}", input);
        }
    }
}
