using System;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string determine = Console.ReadLine();
            string input = Console.ReadLine();
            if (determine == "integer")
            {
               long i = Convert.ToInt64(input);
                Console.WriteLine(i + 1);
            }
            else if (determine == "real")
            {
               double d = Convert.ToDouble(input);
                Console.WriteLine("{0:F2}", d + 1);
            }
            else if (determine == "text")
            {
                Console.WriteLine(input + "*");
            }
            
        }
    }
}
