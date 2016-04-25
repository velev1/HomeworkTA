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

