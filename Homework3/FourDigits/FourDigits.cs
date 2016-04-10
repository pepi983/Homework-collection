using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int d = (num) % 10;
            int c = (num / 10) % 10;
            int b = (num / 100) % 10;
            int a = (num / 1000) % 10;
            string a1 = Convert.ToString(a);
            string b1 = Convert.ToString(b);
            string c1 = Convert.ToString(c);
            string d1 = Convert.ToString(d);
            Console.WriteLine(a + b + c + d);
            Console.WriteLine(d1 + c1 + b1 + a1);
            Console.WriteLine(d1 + a1 + b1 + c1);
            Console.WriteLine(a1 + c1 + b1 + d1);
        }
    }
}
