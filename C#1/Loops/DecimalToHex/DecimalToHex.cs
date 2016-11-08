//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Input
//On the first and only line you will receive an integer in the decimal numeral system.
//Output
//On the only output line write the hexadecimal representation of the read number.
//Constraints
//All numbers will always be valid 64-bit integers.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input             Output
//254	            FE
//6883	            1AE3
//338583669684	    4ED528CBB4

using System;

class DecimalToHex
{
    static void Main()
    {
        long input = Convert.ToInt64(Console.ReadLine());
        string hexNum = "";
        long remainder;

        while (input > 0)
        {
            remainder = input % 16;

            switch (remainder)
            {
                case 10: hexNum += "A"; break;
                case 11: hexNum += "B"; break;
                case 12: hexNum += "C"; break;
                case 13: hexNum += "D"; break;
                case 14: hexNum += "E"; break;
                case 15: hexNum += "F"; break;
                default:
                    hexNum += remainder.ToString();
                    break;
            }
            input = input / 16;
        }
        for (int i = hexNum.Length - 1; i >= 0; i--)
        {
            Console.Write(hexNum[i]);
        }
        Console.WriteLine();
    }
}

