using System;

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();

        int openBrackets = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                openBrackets++;
            }
            else if (input[i] == ')')
            {
                openBrackets--;
            }
        }

        if (openBrackets == 0)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}


