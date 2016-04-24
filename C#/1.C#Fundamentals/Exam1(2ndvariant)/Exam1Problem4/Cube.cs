using System;

namespace Exam1Problem4
{
    class Cube
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fieldSize = (n * 2) - 1;
            int mid = n - 1;
            char empty = ' ';
            char top = '/';
            char side = 'X';
            char edge = ':';
            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                { 
                    else if (col == 0 && row >= mid ||
                        col == mid && row >= mid ||
                        col == fieldSize - 1 && row <= mid ||
                        col >= mid && row == 0 ||
                        col <= mid && row == mid ||
                        col <= mid && row == fieldSize - 1 ||
                        row + col == mid ||
                        row + col == fieldSize - 1 + mid ||
                        col + row == fieldSize - 1 && row <= mid)
                    {
                        Console.Write(edge);
                    }
                    else if (row < mid &&
                        col + row > mid &&
                        col + row <= fieldSize - 1)
                    {
                        Console.Write(top);
                    }
                    else if (col > mid &&
                        col + row <= fieldSize - 1 + mid &&
                        col + row >= fieldSize - 1)
                    {
                        Console.Write(side);
                    }
                    else
                    {
                        Console.Write(empty);
                    }
                    }


                    Console.WriteLine();
                }



            }
    }
}
