//Write a program that reads an integer N(which will always be less than 100 or equal) 
//and uses an expression to check if given N is prime(i.e.it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
//Input
//On the only input line you will receive the number N.
//Output
//Output true if the number is prime and false otherwise.
//Constraints
//N will always be a valid 32-bit integer number, which will be less than 100 or equal.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//2	true
//23	true
//-3	false
//0	false
//1	false

using System;

class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (number <= 0 || number == 1)
        {
            isPrime = false;
        }
        else
        {
            int root = (int)Math.Sqrt(number);

            for (int i = 2; i <= root; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        if(isPrime)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}