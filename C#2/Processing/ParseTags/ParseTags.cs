using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder moddifiedText = new StringBuilder();
        string openTag = "<upcase>";
        string closeTag = "</upcase>";

        int normalTextStart = 0;
        int startIndex = 0;
        int endIndex = 0;

        while (true)
        {
            startIndex = text.IndexOf(openTag, startIndex);
            endIndex = text.IndexOf(closeTag, endIndex);

            for (int i = normalTextStart; i < text.Length; i++)
            {
                if (text[i].ToString() == "<")
                {
                    break;
                }
                moddifiedText.Append(text[i].ToString());
            }

            normalTextStart = endIndex + closeTag.Length;

            if (startIndex == -1)
            {
                break;
            }

            startIndex++;
            endIndex++;
           
            moddifiedText.Append(text.Substring(startIndex + openTag.Length - 1, endIndex - startIndex - closeTag.Length + 1).ToUpper());

        }
        Console.WriteLine(moddifiedText);
    }
}

