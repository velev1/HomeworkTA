﻿using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= input; i++)
        {
            Console.Write("{0} ",i);
        }
    }
}
