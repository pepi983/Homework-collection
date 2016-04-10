using System;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            for(int a = 2; a<=11; a++)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(-a);
                }
            }
        }
    }
}
