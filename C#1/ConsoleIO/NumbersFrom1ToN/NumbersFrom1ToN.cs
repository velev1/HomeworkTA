﻿//Write a program that reads an integer number N from the console and prints all the numbers in the interval[1, n],
//each on a single line.
//Input
//On the only line you will receive the number N
//Output
//You should print the numbers from 1 to N, each on a separate line
//Constraints
//1 <= N< 1000
//N will always be a valid integer number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//3	        1
//          2
//          3

//5	        1
//          2
//          3
//          4
//          5

//1	        1


using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(i);
        }
    }
}

