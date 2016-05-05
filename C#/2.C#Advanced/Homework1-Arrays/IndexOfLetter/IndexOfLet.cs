using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = Convert.ToChar('a' + i);
            }
            string input = Console.ReadLine();
            input = input.ToLower();
            char[] word = input.ToCharArray();
            for (int l = 0; l < word.Length; l++)
            {
                for (int k = 0; k < alphabet.Length; k++)
                {
                    if(word[l] == alphabet[k])
                    {
                        Console.WriteLine(k);
                    }
                }
            }

        }
    }
}
