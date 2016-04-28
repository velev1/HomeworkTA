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

