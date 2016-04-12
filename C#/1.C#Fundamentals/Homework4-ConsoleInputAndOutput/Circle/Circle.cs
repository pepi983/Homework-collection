using System;
using System.Threading;
using System.Globalization;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            float R = float.Parse(Console.ReadLine());
            float pi = (float)Math.PI;
            float perimeter = 2.0F * pi * R;
            float area = pi * (R * R);
            Console.WriteLine("{0:F2} {1:F2}", (float)perimeter, (float)area);
        }
    }
}
