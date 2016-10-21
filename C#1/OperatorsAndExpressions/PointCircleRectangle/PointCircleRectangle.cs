//Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point(x, y) 
//if it is within the circle K({ 1, 1}, 1.5) and out of the rectangle R(top= 1, left= -1, width= 6, height= 2).
//Input
//You will receive the pair of coordinates on the two lines of the input - on the first line you will find x, and on the second - y.
//Output
//Print inside circle if the point is inside the circle and outside circle if it's outside.
//Then print a single whitespace followed by inside rectangle if the point is inside the rectangle and outside rectangle otherwise. See the sample tests for a visual description.
//Constraints
//The coordinates x and y will always be valid floating-point numbers in the range[-1000, 1000].
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests
//Input   Output
//2.5
//2	outside circle outside rectangle

//0
//1	inside circle inside rectangle

//2.5
//1	inside circle inside rectangle

//1
//2	inside circle outside rectangle

using System;

class PointCircleRectangle
{
    static void Main()
    {
        double xCenterOfCircle = 1;
        double yCenterOfCircle = 1;
        double radius = 1.5;
        double xUpLeft = -1;
        double yUpLeft = 1;
        double width = 6;
        double height = 2;

        double xInput = Convert.ToDouble(Console.ReadLine());
        double yInput = Convert.ToDouble(Console.ReadLine());
        //vector magnitude formula
        double lenghtFromCenter = Math.Sqrt(Math.Pow(xInput - xCenterOfCircle, 2) + Math.Pow(yInput - yCenterOfCircle, 2));
        if (lenghtFromCenter <= radius)
        {
            Console.Write("inside circle");
        }
        else
        {
            Console.Write("outside circle");
        }
        if ((xInput >= xUpLeft) && (xInput <= xUpLeft + width) && (yInput <= yUpLeft) && (yInput >= yUpLeft - height))
        {
            Console.WriteLine(" inside rectangle");
        }
        else
        {
            Console.WriteLine(" outside rectangle");
        }
    }
}

