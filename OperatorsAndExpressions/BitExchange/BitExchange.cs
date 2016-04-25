using System;

class BitExchange
{
    static void Main()
    {
        uint number = Convert.ToUInt32(Console.ReadLine());
        // 3rd and 24 bits check
        uint mask = 1 << 3;
        uint bit3 = mask & number;
        if (bit3 != 0)
        {
            bit3 = 1;
        }
        else
        {
            bit3 = 0;
        }
        mask = 1 << 24;
        uint bit24 = mask & number;
        if (bit24 != 0)
        {
            bit24 = 1;
        }
        else
        {
            bit24 = 0;
        }
        if (bit24 != bit3)
        {
            if (bit3 == 0)
            {
                mask = 1 << 24;
                number = mask ^ number;
                mask = 1 << 3;
                number = mask ^ number;
            }
            else
            {
                mask = 1 << 24;
                number = mask | number;
                mask = 1 << 3;
                number = mask ^ number;
            }
        }
        //4th and 25 bits check
        mask = 1 << 4;
        uint bit4 = mask & number;
        if (bit4 != 0)
        {
            bit4 = 1;
        }
        else
        {
            bit4 = 0;
        }
        mask = 1 << 25;
        uint bit25 = mask & number;
        if (bit25 != 0)
        {
            bit25 = 1;
        }
        else
        {
            bit25 = 0;
        }
        if (bit25 != bit4)
        {
            if (bit4 == 0)
            {
                mask = 1 << 25;
                number = mask ^ number;
                mask = 1 << 4;
                number = mask ^ number;
            }
            else
            {
                mask = 1 << 25;
                number = mask | number;
                mask = 1 << 4;
                number = mask ^ number;
            }
        }
        // 5th and 26th bits check
        mask = 1 << 5;
        uint bit5 = mask & number;
        if (bit5 != 0)
        {
            bit5 = 1;
        }
        else
        {
            bit5 = 0;
        }
        mask = 1 << 26;
        uint bit26 = mask & number;
        if (bit26 != 0)
        {
            bit26 = 1;
        }
        else
        {
            bit26 = 0;
        }
        if (bit26 != bit5)
        {
            if (bit5 == 0)
            {
                mask = 1 << 26;
                number = mask ^ number;
                mask = 1 << 5;
                number = mask ^ number;
            }
            else
            {
                mask = 1 << 26;
                number = mask | number;
                mask = 1 << 5;
                number = mask ^ number;
            }
        }
        Console.WriteLine(number);
    }
}

