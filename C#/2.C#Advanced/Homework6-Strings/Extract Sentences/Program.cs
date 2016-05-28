using System;
using System.Linq;

namespace SubStringsInText
{
    class Program
    {
        static public char[] Kurec(string hui)
        {
            var arr = Array.FindAll<char>(hui.ToCharArray(), (c => (!char.IsLetter(c) && (c != '.'))));           
            return arr;
        }
        static void Main(string[] args)
        {
            string substring = Console.ReadLine();
            var text = Console.ReadLine().Split('.').ToArray();

            foreach (var hui in text)
            {
                var patica = hui.Split(Kurec(hui)).ToArray();
                if (patica.Contains(substring))
                {
                    Console.Write(hui.Trim() + ". ");
                }
            }
 
        }
    }
}