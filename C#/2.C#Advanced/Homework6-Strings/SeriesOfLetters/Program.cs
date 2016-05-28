using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<char> kurec = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if(i == 0)
                {
                    kurec.Add(input[i]);
                }
                else if(input[i] != input[i-1])
                {
                    kurec.Add(input[i]);
                }
            }
            Console.WriteLine(String.Join("", kurec));
        }
    }
}
