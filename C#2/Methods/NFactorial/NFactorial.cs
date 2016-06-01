using System;
using System.Numerics;

class NFactorial
{
    static BigInteger CalcFactorial(int number)
    {
        BigInteger result = 1;

        while (number > 1)
        {
            result *= number;
            number--;
        }
        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger result =  CalcFactorial(n);
        Console.WriteLine(result);
    }
}

