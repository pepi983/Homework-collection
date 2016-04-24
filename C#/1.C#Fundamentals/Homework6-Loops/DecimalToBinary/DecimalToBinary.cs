using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            string output = Convert.ToString(input, 2);
            Console.WriteLine(output);
        }
    }
}
