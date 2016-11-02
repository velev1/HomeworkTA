//Write a program that shows the sign(+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Input
//On the first three lines, you will receive the three numbers, each on a separate line
//Output
//Output a single line - the sign of the product of the three numbers
//Constraints
//The input will always consist of valid floating-point numbers
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input     Output
//2
//5
//2	        +

//2
//5
//-2	    -

//-0.5
//0
//-2	    0

using System;

class MultiplicationSign
{
    static void Main()
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());
        string sign = "";
        
        if (num1 == 0 || num2 == 0 || num3 == 0)
        {
            sign = "0";
        }
        //all negative
        else if (num1 < 0 && num2 < 0 && num3 < 0)
        {
            sign = "-";
        }
        //all positive
        else if (num1 > 0 && num2 > 0 && num3 > 0)
        {
            sign = "+";
        }
        //one negative
        else if (num1 < 0 && num2 > 0 && num3 > 0)
        {
            sign = "-";
        }
        else if (num1 > 0 && num2 < 0 && num3 > 0)
        {
            sign = "-";
        }
        else if (num1 > 0 && num2 > 0 && num3 < 0)
        {
            sign = "-";
        }
        //one positive
        else if (num1 > 0 && num2 < 0 && num3 < 0)
        {
            sign = "+";
        }
        else if (num1 < 0 && num2 > 0 && num3 < 0)
        {
            sign = "+";
        }
        else if (num1 < 0 && num2 < 0 && num3 > 0)
        {
            sign = "+";
        }
        Console.WriteLine(sign);
    }
}

