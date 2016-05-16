using System;

namespace Triangle2
{
    class TriangleTwo
    {
        static void Main()
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double side3 = double.Parse(Console.ReadLine());
            double p = (side1 + side2 + side3) / 2.0;
            double kur1 = p - side1;
            double kur2 = p - side2;
            double kur3 = p - side3;
            double almostresult = p * kur1 * kur2 * kur3;
            double area = Math.Sqrt((double)almostresult);
            Console.WriteLine("{0:F2}", area); // tree da e 6i neshto  
        }
    }
}
