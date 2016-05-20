using System;

class Program
{
    static void Main()
    {
        string hexValue = Console.ReadLine();
        long decValue = long.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
        string binary = Convert.ToString((decValue), 2);
        Console.WriteLine(binary);
    }
}
