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

