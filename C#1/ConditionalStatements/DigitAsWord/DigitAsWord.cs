using System;

class DigitAsWord
{
    static void Main()
    {
        string input = Console.ReadLine();

        switch (input)
        {
            case "0": input = "zero"; break;
            case "1": input = "one"; break;
            case "2": input = "two"; break;
            case "3": input = "three"; break;
            case "4": input = "four"; break;
            case "5": input = "five"; break;
            case "6": input = "six"; break;
            case "7": input = "seven"; break;
            case "8": input = "eight"; break;
            case "9": input = "nine"; break;
            default:
                input = "not a digit";
                break;
        }
        Console.WriteLine(input);
    }
}

