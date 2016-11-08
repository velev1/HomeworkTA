//Write a program that calculates N! / K! for given N and K.
//Use only one loop.
//Input
//On the first line, there will be only one number - N
//On the second line, there will be only one number - K
//Output
//Output a single line, consisting of the result from the calculation described above.
//Constraints
//1 < K<N< 100
//Hint: overflow is possible
//N and K will always be valid integer numbers
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input      Output
//5
//2	         60

//6
//5	         6

//8
//3	         6720

using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        var result = new BigInteger(1);
        int range = n - k;
        for (int i = range ; i > 0; i--)
        {
            result *= n;
            n--;
        }
        Console.WriteLine(result);
    }
}

