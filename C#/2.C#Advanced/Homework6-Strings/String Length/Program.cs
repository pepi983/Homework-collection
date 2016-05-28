using System;

namespace String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.PadRight(20, '*'));
        }
    }
}
