using System;

namespace BinToDecimal
{
    class BinToDecimal
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            long output = Convert.ToInt64(binary, 2);
            Console.WriteLine(output);
        }
    }
}
