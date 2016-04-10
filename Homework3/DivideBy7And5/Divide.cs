using System;

namespace DivideBy7And5
{
    class Divide
    {
        static void Main()
        {
            double a = int.Parse(Console.ReadLine());
            bool result1;
            bool result2;
            if (a % 5.0 == 0)
            {
                result1 = true;
            }
            else
            {
                result1 = false;
            }
            if (a % 7.0 == 0)
            {
                result2 = true;
            }
            else
            {
                result2 = false;
            }
            bool result3 = result1 && result2;
            if (result3 == true)
            {
                Console.WriteLine("true " + a);
            }
            else
            {
                Console.WriteLine("false " + a);
            }
            
        }
    }
}
