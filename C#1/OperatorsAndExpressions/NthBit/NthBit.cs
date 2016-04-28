using System;

class NthBit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        byte position = byte.Parse(Console.ReadLine());

        ulong mask = (ulong)1 << position;
        ulong maskAndNumber = number & mask;
        ulong bit = maskAndNumber >> position;
        int result = (int)bit;
        Console.WriteLine(Convert.ToString(result, 2));
    }
}

