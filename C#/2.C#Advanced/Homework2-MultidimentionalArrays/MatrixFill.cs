using System;

namespace FillTheMatrix
{
    class MatrixFill
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            switch (type)
            {
                case "a":
                    TypeA(x);
                    break;
                case "b":
                    TypeB(x);
                    break;
                case "c":
                    TypeC(x);
                    break;
                case "d":
                    TypeD(x);
                    break;
                default:
                    break;
                
            }


        }

        public static void TypeA(int A)
        {

            int[,] matrixA = new int[A, A];
            int number;

            for (int rows = 0; rows < A; rows++)
            {
                number = rows + 1;
                for (int cols = 0; cols < A; cols++)
                {
                    matrixA[rows, cols] = number;
                    number += A;
                }
            }

            Print(matrixA, A);

        }

        public static void TypeB(int B)
        {

            int[,] matrixB = new int[B, B];
            int[,] matrixBClone = new int[B, B];
            int number;

            for (int rows = 0; rows < B; rows++)
            {
                number = rows + 1;
                for (int cols = 0; cols < B; cols++)
                {
                    matrixBClone[rows, cols] = number;
                    matrixB[rows, cols] = number;
                    number += B;
                }
            }

            for (int ReverseCol = 1; ReverseCol < B; ReverseCol +=2)
            {
                for (int ReverseRow = B-1, NormalRow = 0; ReverseRow >= 0 && NormalRow < B; ReverseRow--, NormalRow++)
                {
                    matrixB[ReverseRow, ReverseCol] = matrixBClone[NormalRow, ReverseCol];
                }
            }

            Print(matrixB, B);


        }
        public static void TypeC(int C)
        {
            int[,] matrixC = new int[C, C];
            int number = 1;
            for (int row = C - 1; number <= C * C; row--)
            {
                for (int currentCol = (row >= 0 ? 0 : -row), currentRow = (row >= 0 ? row : 0); currentCol < (C - (row >= 0 ? row : 0));)
                {
                    matrixC[currentRow++, currentCol++] = number++;
                }
            }

            Print(matrixC, C);
        }


        public static void TypeD(int D)
        {
            int[,] matrixD = new int[D,D];
            int rows = 0;
            int cols = 0;
            int rowMax = D - 1;
            int colMax = D - 1;
            int number = 1;

            do
            {
                for (int i = rows; i <= rowMax; i++)
                {
                    matrixD[i, cols] = number;
                    number++;
                }
                cols++;

                for (int i = cols; i <= colMax; i++)
                {
                    matrixD[rowMax, i] = number;
                    number++;
                }
                rowMax--;

                for (int i = rowMax; i >= rows; i--)
                {
                    matrixD[i, colMax] = number;
                    number++;
                }
                colMax--;

                for (int i = colMax; i >= cols; i--)
                {
                    matrixD[rows, i] = number;
                    number++;
                }
                rows++;
            } while (number <= D*D);

            Print(matrixD, D);
        }


        public static void Print(int[,] matrix, int number)
        {
            for (int printRow = 0; printRow < number; printRow++)
            {
                for (int printCol = 0; printCol < number; printCol++)
                {
                    if (printCol == number - 1)
                    {
                        Console.Write(matrix[printRow, printCol]);
                    }
                    else
                    {
                        Console.Write(matrix[printRow, printCol] + " ");
                    }

                }
                Console.WriteLine();
            }
        }


    }
}
