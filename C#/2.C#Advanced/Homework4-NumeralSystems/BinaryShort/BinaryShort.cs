using System;

class Program
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
    }
}

