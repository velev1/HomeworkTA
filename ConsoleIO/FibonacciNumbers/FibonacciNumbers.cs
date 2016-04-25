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

