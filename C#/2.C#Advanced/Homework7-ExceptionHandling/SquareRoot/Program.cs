using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine("{0:F3}", Math.Sqrt(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
                
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
