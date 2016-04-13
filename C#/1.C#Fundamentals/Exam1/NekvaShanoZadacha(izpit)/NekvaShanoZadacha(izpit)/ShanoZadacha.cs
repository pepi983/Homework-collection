using System;

namespace NekvaShanoZadacha_izpit_
{
    class ShanoZadacha
    {
        static void Main()
        {
            int Students = int.Parse(Console.ReadLine());
            int SheetsPerStudent = int.Parse(Console.ReadLine());
            double Price = double.Parse(Console.ReadLine());
            int realm = 500;
            double result = 0;
            result = ((Students * SheetsPerStudent) / (double)realm) * Price;
            Console.WriteLine("{0:F2}", result);
        }
    }
}
