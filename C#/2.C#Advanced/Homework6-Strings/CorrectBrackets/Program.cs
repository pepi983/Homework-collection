using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int openCounter = 0;
            int closeCounter = 0;

            foreach (var symbol in input)
            {
                if (symbol == '(')
                {
                    openCounter++;
                }
                else if (symbol == ')')
                {
                    closeCounter++;
                }
            }
            if (openCounter == closeCounter)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
