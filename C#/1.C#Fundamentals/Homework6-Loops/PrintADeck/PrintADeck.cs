using System;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] deckArr = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            int index = 0;
            switch(input)
            {
                case "2": index = 0; break;
                case "3": index = 1; break;
                case "4": index = 2; break;
                case "5": index = 3; break;
                case "6": index = 4; break;
                case "7": index = 5; break;
                case "8": index = 6; break;
                case "9": index = 7; break;
                case "10": index = 8; break;
                case "J": index = 9; break;
                case "Q": index = 10; break;
                case "K": index = 11; break;
                case "A": index = 12; break;
            }
            for (int i = 0; i <= index; i++)
            {
                Console.Write("{0} of spades, ", deckArr[i]);
                Console.Write("{0} of clubs, ", deckArr[i]);
                Console.Write("{0} of hearts, ", deckArr[i]);
                Console.WriteLine("{0} of diamonds ", deckArr[i]);

            }

        }
    }
}
