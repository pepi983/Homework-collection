using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int RowsCount = int.Parse(Console.ReadLine());
            int ColsCount = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            var coeff = Math.Max(RowsCount, ColsCount);
            bool[,] matrix = new bool[RowsCount, ColsCount];

            var moves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var row = RowsCount - 1;
            var col = 0;
            BigInteger currCellValue = 1;
            BigInteger result = 0;

            foreach (var move in moves)
            {
                var nextRow = move / coeff;
                var nextcol = move % coeff;

                var deltacol = col > nextcol ? -1 : 1;

                while (col != nextcol)
                {
                    if (!matrix[row, col])
                    {
                        result += currCellValue;
                        matrix[row, col] = true;
                    }
                    if (deltacol == 1)
                    {
                        currCellValue *= 2;
                    }
                    else
                    {
                        currCellValue /= 2;
                    }
                    col += deltacol;

                }

                var deltarow = row > nextRow ? -1 : 1;

                while (row != nextRow)
                {
                    if (!matrix[row, col])
                    {
                        result += currCellValue;
                        matrix[row, col] = true;
                    }
                    if (deltarow == 1)
                    {
                        currCellValue /= 2;
                    }
                    else
                    {
                        currCellValue *= 2;
                    }
                    row += deltarow;
                }

            }

            if (!matrix[row, col])
            {
                result += currCellValue;
            }

            Console.WriteLine(result);
        }
    }
}
