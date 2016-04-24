using System;
namespace MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int begnningOfRow = 1;
            int matrix = begnningOfRow;
            for (int i = 1; i <= N; i++)
            {
                Console.Write(begnningOfRow + " ");
                begnningOfRow++;
                matrix = begnningOfRow;
                for (int k = 2; k <= N; k++)
                {
                    Console.Write(matrix + " ");
                    matrix++;
                }
                Console.WriteLine();
            }
        }
    }
}
