using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static ulong CatNumbers(string numbers)
        {
            ulong result = 0;

            foreach (char digit in numbers)
            {
                result = (ulong)(digit - 'a') + result * 21;
            }
            return result;
        }

        static string ExitNumbers(ulong numbersinDec)
        {
            var result = string.Empty;

            do
            {
                char value = (char)('a' + (numbersinDec % 26));
                result = value + result;
                numbersinDec /= 26;


            } while (numbersinDec != 0);



            return result;
        }

        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(CatNumbers).Select(ExitNumbers).ToArray();
            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}