using System;

namespace Triangle3
{
    class TriangleThree
    {
        static void Main()
        {
            double side1 = double.Parse(Console.ReadLine());
            double side2 = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            double rad = (angle * Math.PI) / 180;
            double sin = Math.Sin(rad);
            double almostarea = (double)side1 * side2 * sin;
            double area = almostarea / 2;
            Console.WriteLine("{0:F2}", area); // tree da e 14i neshto  
        }
    }
}
