using System;

class PrintaDeck
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] cards = {"2","3","4","5","6","7","8","9","10","J","Q","K","A" };
        string[] suits = { "spades", "clubs", "hearts", "diamonds" };
        bool isReaxhed = false;

        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < suits.Length; j++)
            {
                if (j == 3)
                {
                    Console.Write("{0} of {1} ", cards[i], suits[j]);
                }
                else
                {
                    Console.Write("{0} of {1}, ", cards[i], suits[j]);
                }
                if (input == cards[i])
                {
                    isReaxhed = true;
                }
            }
            if (isReaxhed)
            {
                break;
            }
            Console.WriteLine();
        }
    }
}
