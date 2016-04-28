using System;
using System.Numerics;

class Calculate_3_
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        var firstPart = new BigInteger(1);
        var range = new BigInteger(n - k);
        int upBorder = n - k;
        int temp = upBorder - 1;
        for (int i = upBorder; i > 0; i--)
        {
            firstPart *= n;
            n--;
            if (temp > 0)
            {
                range *= temp;
                temp--;
            }
        }
        Console.WriteLine(firstPart / range);
    }
}

