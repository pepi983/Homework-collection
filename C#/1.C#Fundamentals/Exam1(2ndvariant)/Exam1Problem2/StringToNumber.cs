using System;

namespace Exam1Problem2
{
    class StringToNumber
    {
        static void Main()
        { 
            int module = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            text = text.ToLower();
            int result = 0;
            for (int i = 0; i < text.Length; i++)      
            {
                char ch = text[i];
                if(ch == 64)
                {                  
                    break;
                }
                else if(Char.IsDigit(ch))
                {
                    result *= (ch - '0'); // result = result * (ch - '0')
                }
                else if(Char.IsLetter(ch))
                {
                    result += (ch - 'a'); 
                }
                else
                {
                    result %= module;
                }

            }
            Console.WriteLine(result);
        }
    }
}
