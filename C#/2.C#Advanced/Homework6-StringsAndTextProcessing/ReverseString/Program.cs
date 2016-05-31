using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] text = input.ToCharArray();
            Array.Reverse(text);
            Console.WriteLine(String.Join("", text));
        }
    }
}
