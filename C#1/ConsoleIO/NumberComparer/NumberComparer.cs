//Write a program that gets two numbers from the console and prints the greater of them.
//Input
//On the first two lines you will receive the two numbers, A and B
//Output
//On the only line print the larger of the two numbers
//* Try implementing it without using if-statements
// Constraints
//The input will always be valid and in the described format.
//The numbers A and B will always be valid real number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input     Output
//5
//6	        6

//10
//5	        10

//0
//0	        0

//-5
//-2	   -2

//1.5
//1.6	    1.6

using System;

class NumberComparer
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double max = Math.Max(a, b);

        Console.WriteLine(max);
    }
}

