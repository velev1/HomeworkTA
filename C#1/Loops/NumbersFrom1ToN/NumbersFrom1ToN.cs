﻿//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, 
//on a single line, separated by a whitespace.
//Input
//The input will consist of a single line - the number N
//Output
//The output should consist of a single line - the numbers from 1 to N, separated by a whitespace
//Constraints
//N will be a valid positive 32-bit integers
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input     Output
//5	        1 2 3 4 5
//1	        1

using System;

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
