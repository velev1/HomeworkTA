//Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
//Your program should work well for very big numbers, e.g.N = 100000.
//Input
//On the only input line, you will receive a single integer - the number N
//Output
//Output a single number - the count of trailing zeroes for the N!
//Constraints
//N will always be a valid positive integer number.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input     Output            Explanation
//10	    2	                3628800
//20	    4	                2432902008176640000
//100000	24999	            think why

using System;

class Trailing0InN_
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int zeros = 0;
        int temp = 0;

        for (int i = n; i > 0; i--)
        {
            if (i % 5 == 0)
            {
                temp = i;

                while (temp >=5 && temp % 5 ==0)
                {
                    temp = temp / 5;
                    zeros++;
                }
            }
        }
        Console.WriteLine(zeros);
    }
}

