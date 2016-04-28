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

