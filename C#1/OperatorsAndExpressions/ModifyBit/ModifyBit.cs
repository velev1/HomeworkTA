﻿//We are given an integer number N(read from the console), 
//a bit value v(read from the console as well) (v = 0 or 1) and a position P(read from the console). 
//Write a sequence of operators(a few lines of C# code) that modifies N to hold the value v at the position P 
//from the binary representation of N while preserving all other bits in N. Print the resulting number on the console.
//Input
//The input will consist of exactly 3 lines containing the following:
//First line - the integer number N.
//Second line - the position P.
//Third line - the bit value v.
//Output
//Output a single line containing the value of the number N with the modified bit.
//Constraints
//N will always be a valid 64-bit unsigned integer.
//P will always be between in the range [0, 64).
//v will be always either 0 or 1.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input     Binary representation       Modified value          Output
//5 
//2 
//0	        00000000 00000101	        00000000 00000001	    1

//0 
//9 
//1	        00000000 00000000	        00000010 00000000	    512

//15 
//1 
//1     	00000000 00001111	        00000000 00001111	    15

//5343 
//7 
//0	        00010100 11011111	        00010100 01011111	    5215

//62241
//11
//0	        11110011 00100001	        11110011 00100001	    62241

using System;

class ModifyBit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        byte position = byte.Parse(Console.ReadLine());
        byte bit = byte.Parse(Console.ReadLine());
        ulong result;

        if (bit == 1)
        {
            ulong mask = (ulong)1 << position;
            result = mask | number; 
        }
        else // bit == 0
        {
            ulong mask = ~((ulong)1 << position);
            result = mask & number;
        }
        Console.WriteLine(result);
    }
}