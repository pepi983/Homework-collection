using System;

namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
           double a = double.Parse(Console.ReadLine());
           double b = double.Parse(Console.ReadLine());
           double c;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.Write(a + " ");
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a + " " + b);
               
            }
        }
    }
}
