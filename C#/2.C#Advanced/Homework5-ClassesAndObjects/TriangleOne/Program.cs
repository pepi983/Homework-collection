using System;

namespace TriangleSideAndAltitude
{
    class TriangleOne
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            double area = (side * altitude) / 2.0;
            Console.WriteLine("{0:F2}", area);
        }
    }
}
