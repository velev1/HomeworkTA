//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Input
//The input will consists of a single line containing a single hexadecimal number as string.
//Output
//The output should consist of a single line - the decimal representation of the number as string.
//Constraints
//All numbers will be valid 64-bit integers.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input             Output
//FE	            254
//1AE3              6883
//4ED528CBB4        338583669684

using System;

class HexToDecimal
{
    static void Main()
    {
        string inputHex = Console.ReadLine();

        int counter = 0;
        long result = 0L;

        for (int i = inputHex.Length - 1; i >= 0; i--)
        {
            switch (inputHex.Substring(i, 1))
            {
                case "A": result += (10 * (long)Math.Pow(16, counter)); break;
                case "B": result += (11 * (long)Math.Pow(16, counter)); break;
                case "C": result += (12 * (long)Math.Pow(16, counter)); break;
                case "D": result += (13 * (long)Math.Pow(16, counter)); break;
                case "E": result += (14 * (long)Math.Pow(16, counter)); break;
                case "F": result += (15 * (long)Math.Pow(16, counter)); break;
                default:
                    result += (Convert.ToInt64(inputHex.Substring(i, 1)) * (long)Math.Pow(16, counter));
                    break;
            }
            counter++;
        }
        Console.WriteLine(result.ToString());
    }
}

