using System;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        string input = Console.ReadLine();

       // input.ToCharArray();
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '<' && input[i + 1] == 'a' )
            {
                output.Append("[");
                int start = input.IndexOf(">", i);
                int end = input.IndexOf("<" , i + 1);

                output.Append(input.Substring(start + 1 , end -start - 1));
                output.Append("](");

                start = input.IndexOf('"' , i);
                end = input.IndexOf('"', i + 10);
                output.Append(input.Substring(start + 1, end - start - 1));
                output.Append(")");
                i = input.IndexOf("</a>", i) + 3;
            }
            else
            {
                output.Append(input[i].ToString());
            }
        }

        Console.WriteLine(output);
    }
}

