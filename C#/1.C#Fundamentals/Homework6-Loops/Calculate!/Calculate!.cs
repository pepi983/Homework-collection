using System;
using System.Numerics;


namespace Calculate
{
    class Calculate
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            long factorial = 1;
            double result = 1;
            for (int i = 1; i <= N; i++)
            {         
                       
                    factorial *= i;
                    result += (double)factorial / Math.Pow(x, i);                  
                    
            }
            Console.WriteLine("{0:F5}", result);

        }
    }
}
    