using System;
using System.Text;

class SubStringInText
{
    static void Main()
    {
        string subString = Console.ReadLine();

        string text = Console.ReadLine();
        int startIndex = 0;
        int counterOfSubstring = 0;

        while (true)
        {
            startIndex = text.IndexOf(subString, startIndex, StringComparison.CurrentCultureIgnoreCase);
            
            if (startIndex >= 0)
            {
                counterOfSubstring++;
            }
            else if (startIndex < 0)
            {
                break;
            }
            startIndex++;
        }

        Console.WriteLine(counterOfSubstring);
    }
}

