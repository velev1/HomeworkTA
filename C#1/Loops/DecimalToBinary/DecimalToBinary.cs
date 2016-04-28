using System;

class DecimalToBinary
{
    static void Main()
    {
        long number = Convert.ToInt64(Console.ReadLine());
        string binNum = "";

        while (number>0)
        {
            binNum += (number % 2).ToString();
            number = number / 2;
        }
        for (int i = binNum.Length - 1; i >= 0; i--)
        {
            Console.Write(binNum[i]);
        }
        Console.WriteLine();
    }
}
