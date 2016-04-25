using System;

class ThirdBit
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());

        int position = 3;
        int mask = 1 << position;
        int inputAndMask = input & mask;
        int result = inputAndMask >> position;
        Console.WriteLine(Convert.ToString(result,2));
    }
}

