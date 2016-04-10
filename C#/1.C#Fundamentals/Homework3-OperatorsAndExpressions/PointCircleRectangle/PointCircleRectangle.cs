using System;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool incc;
            bool inrc = ((x >= -1) && (x <= 5) && (y <= 1) && (y >= -1));
            double distanceCc = Math.Sqrt(((x - 1) * (x - 1) + ((y - 1) * (y - 1))));
            if (distanceCc <= 1.5)
            {
                incc = true;
                Console.Write("inside circle"); 
            }
            else
            {
                incc = false;
                Console.Write("outside circle"); 
            }
            if (inrc == true)
            {
                Console.Write(" inside rectangle");
            }
            else
            {
                Console.Write(" outside rectangle");
            }
        }
    }
}







