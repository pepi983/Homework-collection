using System;

class Program
{
    static void GetMax(string numbers)
    {
        string[] numbersArrString = numbers.Split(' ');
        int[] numberArr = Array.ConvertAll<string, int>(numbersArrString, int.Parse);
        int maxNumber = int.MinValue;
        for (int i = 0; i < numberArr.Length; i++)
        {
            if (numberArr[i] > maxNumber)
            {
                maxNumber = numberArr[i];
            }
        }
        Console.WriteLine(maxNumber);
    }
    static void Main()
    {
        GetMax(Console.ReadLine());
    }
}