using System;

namespace SortNumbers
{
    class SortNumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                if (b > c)
                {
                     Console.Write(a + " ");
                     Console.Write(b + " ");
                     Console.WriteLine(c); 
                }
                else
                {
                    Console.Write(a + " ");
                    Console.Write(c + " ");
                    Console.WriteLine(b);
                }
            }
            else if (a == b)
            {
                if (a > c)
                {
                    Console.Write(a + " ");
                    Console.Write(a + " ");
                    Console.WriteLine(c);
                }
                else
                {
                    Console.Write(c + " ");
                    Console.Write(a + " ");
                    Console.WriteLine(a);
                }
            }
            else if (a == c)
            {
                if (a < b)
                {
                    Console.Write(b + " ");
                    Console.Write(a + " ");
                    Console.WriteLine(a);
                }
                else
                {
                    Console.Write(a + " ");
                    Console.Write(a + " ");
                    Console.WriteLine(b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.Write(b + " ");
                    Console.Write(a + " ");
                    Console.WriteLine(c);
                }
                else
                {
                    Console.Write(b + " ");
                    Console.Write(c + " ");
                    Console.WriteLine(a);
                }
            }
            else if (b == c)
            {
                if (b > a)
                {
                    Console.Write(b + " ");
                    Console.Write(b + " ");
                    Console.WriteLine(a);
                }
                else
                {
                    Console.Write(a + " ");
                    Console.Write(b + " ");
                    Console.WriteLine(b);
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.Write(c + " ");
                    Console.Write(a + " ");
                    Console.WriteLine(b);
                }
                else
                {
                    Console.Write(c + " ");
                    Console.Write(b + " ");
                    Console.WriteLine(a);
                }
            }

        }
    }
}
