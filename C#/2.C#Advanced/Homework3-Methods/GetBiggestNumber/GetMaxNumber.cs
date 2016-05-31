using System;

<<<<<<< HEAD
namespace GetMAxNumber
{
    class GetMAxNumber
    {
        public static int GetBiggestNumber(int num, int num1, int num2)
        {
            int currmax = Math.Max(num, num1);
            if (currmax < num2)
            {
                currmax = num2;
            }
            return currmax;
        }

        static void Main()
        {
            int num = Console.Read() -'0'; 
            int num1 = Console.Read() -'0';
            int num2 = Console.Read() -'0';
            Console.WriteLine((int)GetBiggestNumber(num, num1, num2));
        }
    }
}
=======
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
>>>>>>> 80f4df4e6c9c68b84c8e51f721e06204d4340371
