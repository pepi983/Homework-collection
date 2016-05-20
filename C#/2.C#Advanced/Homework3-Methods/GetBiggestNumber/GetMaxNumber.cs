using System;

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
