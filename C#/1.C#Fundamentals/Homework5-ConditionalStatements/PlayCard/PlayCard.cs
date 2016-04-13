using System;

namespace PlayCard
{
    class PlayCard
    {
        static void Main()
        {
            string input = Console.ReadLine();
             string packa = input.ToLower();
            switch (packa)
            {
                case "2": Console.WriteLine("yes " + input); break;
                case "3": Console.WriteLine("yes " + input); break;
                case "4": Console.WriteLine("yes " + input); break;
                case "5": Console.WriteLine("yes " + input); break;
                case "6": Console.WriteLine("yes " + input); break;
                case "7": Console.WriteLine("yes " + input); break;
                case "8": Console.WriteLine("yes " + input); break;
                case "9": Console.WriteLine("yes " + input); break;
                case "10": Console.WriteLine("yes " + input); break;
                case "j": Console.WriteLine("yes " + input); break;
                case "q": Console.WriteLine("yes " + input); break;
                case "k": Console.WriteLine("yes " + input); break;
                case "a": Console.WriteLine("yes " + input); break;
                default: Console.WriteLine("no " + input); break;

            }

        }
    }
}
