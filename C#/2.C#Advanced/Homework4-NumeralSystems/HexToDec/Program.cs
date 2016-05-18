using System;

class Program
{
    static void Main()
    {
        string hexValue = Console.ReadLine();
        long decValue = long.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine(decValue);
    }
}
