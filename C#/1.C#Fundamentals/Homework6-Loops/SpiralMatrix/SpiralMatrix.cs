using System;

namespace ShanoMatix
{
    class NeoYouBastard
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int[,] matrix = new int[number, number];

            string direction = "right";

            int currentRow = 0;
            int currentCol = 0;

            for (int i = 1; i <= number * number; i++)
            {
                if (direction == "right" && (currentCol >= number || matrix[currentRow, currentCol] != 0))
                {
                    direction = "down";
                    currentCol--;
                    currentRow++;
                }
                else if (direction == "down" && (currentRow >= number || matrix[currentRow, currentCol] != 0))
                {
                    direction = "left";
                    currentCol--;
                    currentRow--;
                }
                else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
                {
                    direction = "up";
                    currentCol++;
                    currentRow--;
                }
                else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
                {
                    direction = "right";
                    currentRow++;
                    currentCol++;
                }

                matrix[currentRow, currentCol] = i;

                if (direction == "right")
                {
                    currentCol++;
                }
                else if (direction == "down")
                {
                    currentRow++;
                }
                else if (direction == "left")
                {
                    currentCol--;
                }
                else if (direction == "up")
                {
                    currentRow--;
                }
            }
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}