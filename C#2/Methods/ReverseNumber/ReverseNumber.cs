using System;

class ReverseNumber
{
    static void PrintReverseNumber(string number)
    {
        for (int i = number.Length - 1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }
    }

    static void Main()
    {
        string number = Console.ReadLine();
        PrintReverseNumber(number);
    }
}

