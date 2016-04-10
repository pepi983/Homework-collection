using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            float width = float.Parse(Console.ReadLine());
            float height = float.Parse(Console.ReadLine());
            float area = Math.Abs(width * height);
            float perimeter = Math.Abs((2 * width) + (2 * height));
            Console.WriteLine(area + " " + perimeter);
        }
    }
}
