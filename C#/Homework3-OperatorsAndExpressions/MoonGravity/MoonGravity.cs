using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            float W = float.Parse(Console.ReadLine());
            float WeightOnMoon = (W * 17)/100;
            Console.WriteLine("{0:F3}", WeightOnMoon);
        }
    }
}
