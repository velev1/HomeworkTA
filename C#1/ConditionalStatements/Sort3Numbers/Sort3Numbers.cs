//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Don’t use arrays and the built-in sorting functionality.
//Input
//On the first three lines, you will receive the three numbers, each on a separate line.
//Output
//Output a single line on the console - the sorted numbers, separated by a whitespace
//Constraints
//The three numbers will always be valid integer numbers in the range [-1000, 1000]
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input     Output
//3
//2
//1	        3 2 1

//-5
//3
//-5	    3 -5 -5

//1
//2
//20	    20 2 1


using System;

class Sort3Numbers
{
    static void Main()
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());

        if (num1 >= num2 && num1 >= num3)
        {
            if (num2 >= num3)
            {
                Console.WriteLine("{0} {1} {2}",num1,num2,num3);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}",num1,num3,num2);
            }
        }
        else if (num2 > num1 && num2>=num3)
        {
            if (num1 >= num3)
            {
                Console.WriteLine("{0} {1} {2}",num2,num1,num3);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}",num2,num3,num1);
            }
        }
        else
        {
            if (num1>=num2)
            {
                Console.WriteLine("{0} {1} {2}",num3,num1,num2);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}",num3,num2,num1);
            }
        }
    }
}
