using System;

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            long OddProduct = 1;
            long EvenProduct = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    OddProduct *= int.Parse(numbers[i]);
                }
                else
                {
                    EvenProduct *= int.Parse(numbers[i]);
                }

                
            }
            if(OddProduct == EvenProduct)
            {
                Console.WriteLine("yes " + OddProduct);
            }
            else
            {
                Console.WriteLine("no " + OddProduct + " " + EvenProduct);
            }
        }
    }
}
