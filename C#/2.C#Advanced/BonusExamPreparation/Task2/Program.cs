using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] output = new bool[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                output[i] = true;
                for (int j = 2; j < input.Length; j++)
                {
                    var currDifference = Math.Abs(input[j - 1] - input[j]);
                    var lastDifference = Math.Abs(input[j - 2] - input[j - 1]);
                    if (lastDifference > currDifference || currDifference - lastDifference > 1)
                    {
                        output[i] = false;
                        break;
                    }
                }
            }
            Console.WriteLine(String.Join("\n", output));
        }
    }
}
