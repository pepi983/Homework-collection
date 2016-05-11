using System;
using System.Linq;


namespace MaximalSum
{
    class MaxSum
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 
            int[][] matrix = new int[numbers[0]][];

            for (int i = 0; i < numbers[0]; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int bestSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < numbers[1] - 2; col++)
                {
                    int sum = matrix[row][col] +
                              matrix[row][col + 1] +
                              matrix[row][col + 2] +
                              matrix[row + 1][col] +
                              matrix[row + 1][col + 1] +
                              matrix[row + 1][ col + 2] +
                              matrix[row + 2][col] +
                              matrix[row + 2][col + 1] +
                              matrix[row + 2][col + 2];
                    if (sum > bestSum)
                        bestSum = sum;
                }
            }

            Console.WriteLine(bestSum);

        }
    }
}
