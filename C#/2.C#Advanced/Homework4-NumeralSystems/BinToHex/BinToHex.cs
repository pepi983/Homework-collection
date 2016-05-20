using System;

class Program
{
    static void Main()
    {
        long deciaml = Convert.ToInt64(Console.ReadLine(), 2);
        string hexValue = deciaml.ToString("X");
        Console.WriteLine(hexValue);
    }
}
