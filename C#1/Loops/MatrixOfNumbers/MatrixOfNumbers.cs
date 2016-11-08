﻿//Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below.
//Use two nested loops.
//Challenge: achieve the same effect without nested loops
//Input
//The input will always consist of a single line, which contains the number N
//Output
//See the examples.
//Constraints
//1 <= N <= 20
//N will always be a valid integer number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input     Output
//2	        1 2
//          2 3

//3	        1 2 3
//          2 3 4
//          3 4 5

//4	        1 2 3 4
//          2 3 4 5
//          3 4 5 6
//          4 5 6 7

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0} ",j + i);
            }
            Console.WriteLine();
        }
    }
}
