using System;

namespace SayHelloo
{
    class SayHello
    {
        static void PrintHello(string name)
        {
            
            Console.WriteLine("Hello, {0}!", name);
        }

        static void Main()
        {
            string name = Console.ReadLine();
            PrintHello(name);
        }
    }
}
