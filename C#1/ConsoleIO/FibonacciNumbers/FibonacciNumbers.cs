//Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence
//(at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Input
//On the only line you will receive the number N
//Output
//On the only line you should print the first N numbers of the sequence, separated by ", " (comma and space)
//Constraints
//1 <= N <= 50
//N will always be a valid positive integer number
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input     Output
//1	        0
//3	        0, 1, 1
//10	    0, 1, 1, 2, 3, 5, 8, 13, 21, 34



 
using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        
        long fib = 0;
        if (n==1)
        {
            Console.WriteLine(fib);
        }
        else if (n == 2)
        {
            string fibSeq = "0, 1";
            Console.WriteLine(fibSeq);
        }
        else
        {
         //edited
            long fib1 = 0;
            long fib2 = 1;
            string fibSeq = "0, 1";
           
            for (int i = 2; i < n; i++)
            {
                fib = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib;
                fibSeq += ", ";
                fibSeq += fib.ToString();
            }
            Console.WriteLine(fibSeq);
        }
    }
}

