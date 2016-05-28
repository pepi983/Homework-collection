using System;

namespace SubStringsInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            int counter = 0;
            for (int i = 0; i < text.Length - substring.Length + 1; i++)
            {
                if (text.Substring(i, substring.Length) == substring)
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);
        }
    }
}