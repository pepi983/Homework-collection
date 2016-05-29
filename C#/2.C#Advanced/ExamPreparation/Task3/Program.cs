using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            long maxSum = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }
            for (int i = 0; i + 2 < n; i++)
            {
                for (int j = 0; j + 4 < n; j++)
                {
                    if ((matrix[i, j] + 1 == matrix[i, j + 1]) 
                        && (matrix[i, j] + 2 == matrix[i, j + 2])
                        && (matrix[i, j] + 3 == matrix[i + 1, j + 2])
                        && (matrix[i, j] + 4 == matrix[i + 2, j + 2])
                        && (matrix[i, j] + 5 == matrix[i + 2, j + 3])
                        && (matrix[i, j] + 6 == matrix[i + 2, j + 4]))
                    {
                        long currSum = 7L * matrix[i, j] + 21;
                        if (maxSum < currSum)
                        {
                            maxSum = currSum;
                           
                        }
                        currSum = 0;
                    }
                }
            }
            if (maxSum != long.MinValue)
            {
                Console.WriteLine("YES {0}", maxSum);
            }
            else
            {
                long noMatchSum = 0;
                for (int i = 0; i < n; i++)
                {
                    noMatchSum += matrix[i, i];                   
                }
                Console.WriteLine("NO {0}", noMatchSum);
            }

        }
    }
}
