using System;

class DecimalToBinary
{
    static string DecToBin(long number)
    {
        string result = "";
        int remeinder = 0;

        while (number > 0) 
        {
            remeinder = (int)(number % 2);
            number /= 2;
            result = remeinder.ToString() + result;
        } 

        return result;
    }

    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        string result = DecToBin(n);
        Console.WriteLine(result);
    }
}

