using System;

namespace Interval
{
    class Interval
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (n > m)
            {
                for (m = m; m <= n; m++)
                {
                    if (m % 5 == 0)
                    {
                        bool true1 = true;
                    }
                    else
                    {
                        bool true1 = false;
                    }
                }   
                else
                {
                    for (n = n; n <= m; n++)
                    {
                        if (n % 5 == 0)
                        {
                            bool true2 = true;
                        }
                        else
                        {
                            bool true2 = false;
                        }
                    }
                }
            }

        }
    }
}
