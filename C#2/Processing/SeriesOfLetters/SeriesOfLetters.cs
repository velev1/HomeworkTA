using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();

        input.ToCharArray();

        char letter = input[0];

        StringBuilder output = new StringBuilder();
        output.Append(letter);

        for (int i = 1; i < input.Length; i++)
        {
            if (letter != input[i])
            {
                letter = input[i];
                output.Append(letter);
            }
        }

        Console.WriteLine(output);
    }
}
