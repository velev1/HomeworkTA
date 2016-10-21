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
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0 || number == 1)
        {
            Console.WriteLine("false");
        }
        else if (number < 11)//(number == 2 || number == 3 || number == 5 || number == 7)
        {
            int counter = 0;
            while (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
            {
                while (number % 2 == 0)
                {
                    number = number / 2;
                    counter++;
                }
                while (number % 3 == 0)
                {
                    number = number / 3;
                    counter++;
                }
                while (number % 5 == 0)
                {
                    number = number / 5;
                    counter++;
                }
                while (number % 7 == 0)
                {
                    number = number / 7;
                    counter++;
                }
            }
            if (counter > 1)
            {
                Console.WriteLine("false");
            }
            else if (counter == 1)
            {
                Console.WriteLine("true");
            }
        }
        else if (number > 10)
        {
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}

