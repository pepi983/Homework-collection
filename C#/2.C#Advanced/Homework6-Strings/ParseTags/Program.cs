using System;
using System.Linq;

namespace ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {'<', '>'}).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "/upcase")
                {
                    input[i] = "";
                    input[i-1] = input[i-1].ToUpper();
                }
                if (input[i] == "upcase")
                {
                    input[i] = "";
                }
            }
            Console.WriteLine(String.Join("", input));
        }
    }
}
