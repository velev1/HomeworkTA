//Write a program that calculates the greatest common divisor(GCD) of given two integers A and B.
//Use the Euclidean algorithm(find it in Internet).
//Input
//On the first and only line of the input you will receive the 2 integers A and B, separated by a whitespace.
//Output
//Output a single number - the GCD of the numbers A and B.
//Constraints
//The numbers A and B will always be valid integers in the range [2, 500].
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input     Output
//3 2	    1
//60 40	    20
//5 15	    5

using System;

class EuclideanАlgorithm
{
    static void Main()
    {
        string numbers = Console.ReadLine();

        string[] arrNums = numbers.Split(' ');

        int firstNumber = 0;
        int secondNumber = 0;
        int counter = 0;

        for (int i = 0; i < arrNums.Length; i++)
        {
            if (arrNums[i] != string.Empty)
            {
                if (counter == 0)
                {
                    firstNumber = Convert.ToInt32(arrNums[i].ToString());
                    counter++;
                }
                else
                {
                    secondNumber = Convert.ToInt32(arrNums[i].ToString());
                    counter++;
                }
            }
        }
        int max = Math.Max(firstNumber, secondNumber);
        int min = Math.Min(firstNumber, secondNumber);
        int remainder = 1;
        while (remainder > 0)
        {
            remainder = max % min;
            max = min;
            min = remainder;
        }
        Console.WriteLine(max);
    }
}
