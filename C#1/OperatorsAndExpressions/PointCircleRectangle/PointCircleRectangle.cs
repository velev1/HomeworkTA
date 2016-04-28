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

