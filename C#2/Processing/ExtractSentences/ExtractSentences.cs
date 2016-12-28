using System;
using System.Collections.Generic;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();
        string wordInMiddle = " " + word + " ";
        string wordInStart = " "+word + " ";
        
        // dasdasdsad word dasdsad
        //  dasdasd word.
        // word dasdas

        //Print only the sentences containing the word on a single line
        List<char> separators = new List<char>();
        
        //char[] separators = { '.', '!', '?' };
        for (int i = 0; i < text.Length; i++)
        {
            if ((text[i] >= 'a' && text[i] <= 'z')||
                (text[i] >= 'A' && text[i] <= 'Z')||
                text[i]>= '0' && text[i] <= '9' ||
                text[i] == ' ')
            {
                continue;
            }
            else
            {
                separators.Add(text[i]);
            }
        }
        
        string[] sentences = text.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);


        int index = 0;
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].ToLower().Contains(wordInStart.ToLower()) ||
                sentences[i].ToLower().Contains(word.ToLower() + " ") ||
                sentences[i].ToLower().Contains(wordInMiddle.ToLower()) ||
                sentences[i].ToLower().Contains(" "+ word.ToLower() + separators[index]))
            {
                Console.Write(sentences[i]+separators[index] );
            }
            index++;
        }
    }
}

