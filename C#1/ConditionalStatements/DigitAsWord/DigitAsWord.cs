//Write a program that read a digit[0 - 9] from the console, and depending on the input, shows the digit as a word(in English).
//Print "not a digit" in case of invalid input.
//Use a switch statement.
//Input
//The input consists of one line only, which contains the digit.
//Output
//Output a single line - should the input be a valid digits, print the english word for the digits.Otherwise, print "not a digit".
//Constraints
//The input will never be an empty line.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input      Output
//-0.1	     not a digit
//1	         one
//9	         nine
//-9	     not a digit
//kek        not a digit


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

