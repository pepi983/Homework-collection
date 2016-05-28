using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();  
            foreach (char c in input)
            {
                Console.Write("\\u{0:X4}", (int)c); 
            }
        }
    }
}
