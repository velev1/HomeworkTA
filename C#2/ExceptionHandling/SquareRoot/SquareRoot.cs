using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            double number = double.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                double result = Math.Sqrt(number);
                Console.WriteLine("{0:F3}", result);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
    

        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

