//Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

//Input

//On the first 5 lines you will receive the 5 numbers, each on a separate line
//Output

//On the only output line, write the biggest of the 5 numbers
//Constraints

//The 5 numbers will always be valid floating-point numbers in the range[-200, 200]
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//4
//4
//4
//4
//4	        4

//-0.5
//-10
//0
//-1
//-3	    0


using System;

class BiggestOf5
{
    static void Main()
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());
        double num4 = Convert.ToDouble(Console.ReadLine());
        double num5 = Convert.ToDouble(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3 && num1>=num4 && num1>=num5)
        {
            Console.WriteLine(num1);
        }
        else if (num2 > num1 && num2>=num3 && num2>= num4 && num2 >= num5)
        {
            Console.WriteLine(num2);
        }
        else if (num3 > num1 && num3 > num2 && num3 >= num4 && num3 >=num5)
        {
            Console.WriteLine(num3);
        }
        else if (num4 > num1 && num4 >num2 && num4 > num3 && num4 >= num5)
        {
            Console.WriteLine(num4);
        }
        else 
        {
            Console.WriteLine(num5);
        }
    }
}

