using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class EnglishDigit
    {
        static void GetLastDigit(int num)
        {
            string[] digit = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int LastDigit = num % 10;
            Console.WriteLine(digit[LastDigit]);
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            GetLastDigit(num);
            
        }
    }
}
