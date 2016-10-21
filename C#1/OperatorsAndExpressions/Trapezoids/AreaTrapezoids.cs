//Write an expression that calculates trapezoid's area by given sides a and b and height h. 
//The three values should be read from the console in the order shown below. All three value will be floating-point numbers.
//Input
//The input will consist of exactly 3 lines:
//The side a on the first line.
//The side b on the second line.
//The height h on the third line.
//Output
//Output a single line containing a single value - the area of the trapezoid.Output the area with exactly 7-digit precision after the floating point.
//Constraints
//All numbers will always be valid floating-point numbers in the range [-500, 500].
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//5
//7
//12	72.0000000

//2
//1
//33	49.5000000

//8.5
//4.3
//2.7	17.2800000

//100
//200
//300	45000.0000000

//0.222
//0.333
//0.555	0.1540125

using System;

class AreaTrapezoids
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double h = Convert.ToDouble(Console.ReadLine());
        double area = (a + b) * (h / 2);

        Console.WriteLine("{0:F7}", area);
    }
}

