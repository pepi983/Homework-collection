using System;

namespace MMSAOfNumbers
{
    class MMSAOfNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0.0;
            double average = 0.0;

            for (int i = 1; i <= N; i++)
            {
                double number = double.Parse(Console.ReadLine());
                min = Math.Min(min, (double)number);
                max = Math.Max(max, (double)number);
                sum += (double)number;

                
            }
            average = (double)sum / N;

           
            Console.WriteLine("min=" + "{0:F2}", min);
            Console.WriteLine("max=" + "{0:F2}", max);
            Console.WriteLine("sum=" + "{0:F2}", sum);
            Console.WriteLine("avg=" + "{0:F2}", average);


        }
    }
}
