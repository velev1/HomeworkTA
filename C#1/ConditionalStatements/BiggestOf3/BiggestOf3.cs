//Write a program that finds the biggest of three numbers that are read from the console.

//Input

//On the first three lines you will receive the three numbers, each on a separate line.
//Output

//On the only output line, write the biggest of the three numbers.
//Constraints

//The three numbers will always be valid floating-point numbers in the range [-200, 200].
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input     Output
//4
//4
//4	         4
//-0.5
//-10
//0	         0


using System;

class BiggestOf3
{
    static void Main()
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());
        double num3 = Convert.ToDouble(Console.ReadLine());

        double max;
        //First way:
        max = Math.Max(num1, num2);
        max = Math.Max(max, num3);
        Console.WriteLine(max);

        //second way:
        //if (num1 >= num2)
        //{
        //    if (num1 >= num3)
        //    {
        //        max = num1;
        //        Console.WriteLine(max);
        //    }
        //    else
        //    {
        //        max = num3;
        //        Console.WriteLine(max);
        //    }
        //}
        //else if (num1 < num2)
        //{
        //    if (num2 >= num3)
        //    {
        //        max = num2;
        //        Console.WriteLine(max);
        //    }
        //    else
        //    {
        //        max = num3;
        //        Console.WriteLine(max);
        //    }
        //}
        
    }
}
