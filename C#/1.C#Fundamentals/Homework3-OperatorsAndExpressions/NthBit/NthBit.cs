using System;

class NthBit
{ 
    static void Main()
    {
        long P = long.Parse(Console.ReadLine()); 
        int N = int.Parse(Console.ReadLine());
        int positions = N; 
        int mask = 1 << positions; 
        long bitFinder = mask & P;
        long bit = bitFinder >> positions;
        Console.WriteLine(bit);

    }
 }
