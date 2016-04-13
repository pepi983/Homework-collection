using System;

namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double max1 = Math.Max(a, Math.Max(b, c));
            double max2 = Math.Max(max1, Math.Max(d, e));
            Console.WriteLine(max2);
        }
    }
}
