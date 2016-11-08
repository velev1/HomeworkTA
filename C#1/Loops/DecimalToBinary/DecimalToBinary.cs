//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Input
//On the only input line you will receive the decimal integer number.
//Output
//Output a single string - the representation of the input decimal number in it's binary representation.
//Constraints
//All numbers will always be valid 32-bit integers.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input          Output
//0	             0
//3	             11
//43691	         1010101010101011
//236476736	     1110000110000101100101000000

using System;

class DecimalToBinary
{
    static void Main()
    {
        long number = Convert.ToInt64(Console.ReadLine());
        string binNum = "";

        while (number>0)
        {
            binNum += (number % 2).ToString();
            number = number / 2;
        }
        for (int i = binNum.Length - 1; i >= 0; i--)
        {
            Console.Write(binNum[i]);
        }
        Console.WriteLine();
    }
}
