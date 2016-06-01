using System;

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();

        int openBrackets = 0;
        int closeBrackets = 0;
        bool correct = true;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].ToString() == "(")
            {
                openBrackets++;
            }
            if (input[i].ToString() == ")")
            {
                closeBrackets++;
            }
            if (closeBrackets > openBrackets)
            {
                correct = false;
                break;
            }
        }

        if (openBrackets == closeBrackets)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}

