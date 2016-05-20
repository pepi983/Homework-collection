using System;

class Program
{
    static void Main()
    {
        long decValue = long.Parse(Console.ReadLine());
        string hexValue = decValue.ToString("X");
        Console.WriteLine(hexValue);
    }
}

