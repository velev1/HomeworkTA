//Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x^2 + … + N!/x^N.
//Use only one loop.Print the result with 5 digits after the decimal point.
//Input
//On the first line you will receive one number - N.
//On the second line you will receive another number - x.
//Output
//Output only one number - the sum of the sequence for the given N and x.
//Constraints
//N will always be a valid integer between 2 and 10, inclusive.
//X will always be a valid floating-point number between 0.5 and 100
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input     Output
//3
//2	        2.75000

//4
//3	        2.07407

//5
//-4	    0.75781


using System;

class Calculate_
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());
        double sum = 1.0;
        long fact = 1;
      
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            sum += fact / Math.Pow(x, i);
        }
        Console.WriteLine("{0:F5}",sum);
    }
}
