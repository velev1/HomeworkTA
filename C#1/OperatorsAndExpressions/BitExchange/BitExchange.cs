﻿//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).
//Input
//On the only input line you will receive the unsigned integer number whose bits you must exchange.
//Output
//On the only output line print the value of the integer with the exchanged bits.
//Constraints
//N will always be a valid 32-bit unsigned integer.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input         Binary representation                       Binary representation after exchange        Output
//1140867093	01000 100 00000000 01000000 00 010 101	        01000010 00000000 01000000 00100101	        1107312677
//255406592	    00001111 00111001 00110010 00000000	        00001000 00111001 00110010 00111000	        137966136
//4294901775	11111111 11111111 00000000 00001111	        11111001 11111111 00000000 00111111	        4194238527
//5351	        00000000 00000000 00010100 11100111	        00000100 00000000 00010100 11000111	        67114183
//2369124121	10001101 00110101 11110111 00011001	        10001011 00110101 11110111 00101001     	2335569705

using System;

class BitExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        uint mask = (uint)7 << 3;
        uint smalBits = mask & number; //smalBits - bits in position 3,4 and 5
        smalBits >>= 3;
        smalBits <<= 24;
        uint maskSecond = (uint)7 << 24;
        uint bigBits = maskSecond & number; // bits in position 24,25 and 26
        bigBits >>= 24;
        bigBits <<= 3;
        uint maskErase = ~((uint)7 << 3);
        number = number & maskErase;
        maskErase = ~((uint)7 << 24);
        number &= maskErase;
        number |= smalBits;
        number |= bigBits;

        Console.WriteLine(number);
    }
}

