using System;

class BinaryToHexadecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        int rem = input.Length % 4;
        input = input.PadLeft((4 - rem) + input.Length, '0');

        string temp = "";
        string result = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            temp = input[i].ToString() + temp;

            if (temp.Length == 4)
            {
                switch (temp)
                {
                    case "0000": result = "0" + result; temp = ""; break;
                    case "0001": result = "1" + result; temp = ""; break;
                    case "0010": result = "2" + result; temp = ""; break;
                    case "0011": result = "3" + result; temp = ""; break;
                    case "0100": result = "4" + result; temp = ""; break;
                    case "0101": result = "5" + result; temp = ""; break;
                    case "0110": result = "6" + result; temp = ""; break;
                    case "0111": result = "7" + result; temp = ""; break;
                    case "1000": result = "8" + result; temp = ""; break;
                    case "1001": result = "9" + result; temp = ""; break;
                    case "1010": result = "A" + result; temp = ""; break;
                    case "1011": result = "B" + result; temp = ""; break;
                    case "1100": result = "C" + result; temp = ""; break;
                    case "1101": result = "D" + result; temp = ""; break;
                    case "1110": result = "E" + result; temp = ""; break;
                    case "1111": result = "F" + result; temp = ""; break;
                }
            }
        }
        result = result.TrimStart(new char[] { '0' });
        Console.WriteLine(result);
    }
}

