using System;

class BinaryToDecimal
{
    static void Main()
    {
        string inputBin = Console.ReadLine();
        int counter = 0;
        long result = 0L;

        for (int i = inputBin.Length - 1; i >= 0; i--)
        {
             result += (Convert.ToInt64(inputBin.Substring(i, 1)) * (long)Math.Pow(2, counter));
            counter++;
        }
        Console.WriteLine(result);
    }
}

