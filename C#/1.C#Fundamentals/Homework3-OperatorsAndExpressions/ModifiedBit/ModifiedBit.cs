using System;

namespace ModifiedBit
{
    class ModifiedBit
    {
        static void Main()
        {
            ulong N = ulong.Parse(Console.ReadLine()); 
            int P = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine()); 
            int position = P;
            if (v == 1)
            {
                ulong maskFor1 = (ulong)1 << position; 
                ulong BitFinderFor1 = maskFor1 | N; 
                Console.WriteLine(BitFinderFor1);                
            }
            else
            {
                ulong maskFor0 = (ulong)~(1 << position);
                ulong BitFinderFor0 = maskFor0 & N;
                Console.WriteLine(BitFinderFor0);
            }
           
        }
    }
}
