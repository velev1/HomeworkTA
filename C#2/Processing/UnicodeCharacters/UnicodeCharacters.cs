using System;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();

        input.ToCharArray();

        foreach (var item in input)
        {
            Console.Write(@"\u" + ((int)item).ToString("X4"));
        }
    }
}

