using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void GetReverse(char[] numbers)
        {
            Array.Reverse(numbers);
            Console.WriteLine(string.Join("", numbers));
        }
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            char[] numbers = num.ToCharArray();
            GetReverse(numbers);
        }
    }
}
