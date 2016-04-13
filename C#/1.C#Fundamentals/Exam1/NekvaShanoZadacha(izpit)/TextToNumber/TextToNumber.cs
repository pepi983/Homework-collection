using System;

namespace TextToNumber
{
    class TextToNumber
    {
        static void Main()
        {
            int module = 2001; //int.Parse(Console.ReadLine());
            string text = "Hello, .NET, my name is Peter 8-)@"; //Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                Console.WriteLine(currentChar);
            }
        }
    }
}
