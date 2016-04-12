using System;


class Program
{
    static void Main()
    {
        double n = 0;
        double length = double.Parse(Console.ReadLine());
        for (int i = 0; i < length; i++)
        {
            double nn = double.Parse(Console.ReadLine());
            n = n + nn;
        }
        Console.WriteLine(n);
    }
}