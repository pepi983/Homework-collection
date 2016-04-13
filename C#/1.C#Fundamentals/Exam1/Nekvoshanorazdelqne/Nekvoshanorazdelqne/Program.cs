using System;

namespace Nekvoshanorazdelqne
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1,2,3,45,12,56,123";
            string[] strArray = input.Split(',');
            int[] intArr = new int[strArray.Length];
            
            for (int i = 0; i < strArray.Length; i++)
            {
                intArr[i] = int.Parse(strArray[i]);
            }
            Console.WriteLine(intArr);





           // int[] numArr = new int[5];
           // for (int i = 0; i < 5; i++)
           // {
           //     numArr[i] = int.Parse(Console.ReadLine());
           // }
           // Console.WriteLine(numArr);


        }
    }
}
