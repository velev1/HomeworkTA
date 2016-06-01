using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexNum = Console.ReadLine();

        long number = 0;
        int power = 0;

        for (int i = hexNum.Length - 1; i >= 0; i--)
        {

            switch (hexNum[i].ToString())
            {
                case "A": number += (long)Math.Pow(16, power) * 10; power++; break;
                case "B": number += (long)Math.Pow(16, power) * 11; power++; break;
                case "C": number += (long)Math.Pow(16, power) * 12; power++; break;
                case "D": number += (long)Math.Pow(16, power) * 13; power++; break;
                case "E": number += (long)Math.Pow(16, power) * 14; power++; break;
                case "F": number += (long)Math.Pow(16, power) * 15; power++; break;
                default:
                    number += (long)Math.Pow(16, power) * (hexNum[i] - '0'); power++; 

                    break;
            }
        }
        Console.WriteLine(number);
    }
}

