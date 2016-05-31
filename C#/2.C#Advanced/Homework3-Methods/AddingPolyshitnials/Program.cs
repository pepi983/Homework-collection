using System;

namespace AddingPolyshitnials
{
    class Program
    {
        static void Polyshitnials(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] += arr2[i];
            }
            Console.WriteLine(String.Join(" ", arr1));


        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();
            string[] inputtedA = inputA.Split(' ');
            string[] inputtedB = inputB.Split(' ');
            int[] numberA = Array.ConvertAll<string, int>(inputtedA, int.Parse);
            int[] numberB = Array.ConvertAll<string, int>(inputtedB, int.Parse);
            Polyshitnials(numberA, numberB);
        }
    }
}
