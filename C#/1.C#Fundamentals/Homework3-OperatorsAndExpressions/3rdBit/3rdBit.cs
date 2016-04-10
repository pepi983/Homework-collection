using System;

namespace _3rdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;        
            int nAndMask = n & mask;  
            int bit = nAndMask >> p;    
            Console.WriteLine(bit);
        }
    }
}
