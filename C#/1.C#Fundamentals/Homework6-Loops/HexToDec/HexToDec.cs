using System;

namespace BinToDecimal
{
    class BinToDecimal
    {
        static void Main()
        {
            string hexademical = Console.ReadLine();
            long output = Convert.ToInt64(hexademical, 16);
            Console.WriteLine(output);
        }
    }
}
