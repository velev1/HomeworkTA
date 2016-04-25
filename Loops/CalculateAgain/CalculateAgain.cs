using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        var result = new BigInteger(1);
        int range = n - k;
        for (int i = range ; i > 0; i--)
        {
            result *= n;
            n--;
        }
        Console.WriteLine(result);
    }
}

