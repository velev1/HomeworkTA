using System;

class BinaryToDecimal
{
    static void Main()
    {
        string inputBin = Console.ReadLine();

        long number = 0L;
        int power = 0;

        for (int i = inputBin.Length - 1; i >= 0; i--)
        {
            number += (long)Math.Pow(2, power) * (inputBin[i] - '0');
            power++;
        }
        Console.WriteLine(number);
    }
}

