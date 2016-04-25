using System;

class ModifyBit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        byte position = byte.Parse(Console.ReadLine());
        byte inputBit = byte.Parse(Console.ReadLine());

        ulong mask;
        ulong result;

        if (inputBit == 1)
        {
            mask = (ulong)inputBit << position;
            result = mask | number;
            Console.WriteLine(result);
        }
        else
        {
            ulong lastBit = number >> position;
            ulong maskForLastBit = 1 << 0;
            ulong checkLastBit = lastBit & maskForLastBit;
            if (checkLastBit == 1)
            {
                inputBit = 1;
                mask = (ulong)inputBit << position;
                result = mask ^ number;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}

