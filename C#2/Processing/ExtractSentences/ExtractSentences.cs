using System;
using System.Collections.Generic;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        string temp = " " + word + " ";

        List<string> sentences = new List<string>();

        int startIndex = 0;
        int endIndex = 0;

        while (true)
        {
            endIndex = text.IndexOf(".", endIndex);
            if (endIndex == -1)
            {
                break;
            }

            sentences.Add(text.Substring(startIndex, endIndex - startIndex + 1));

            endIndex++;
            startIndex = endIndex;
        }

        for (int i = 0; i < sentences.Count; i++)
        {
            if (sentences[i].Contains(temp) || sentences[i].Contains(" " + word + "."))
            {
                Console.Write(sentences[i]);
            }
        }
    }
}

