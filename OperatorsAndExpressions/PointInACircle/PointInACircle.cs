using System;

class PointInACircle
{
    static void Main()
    {
        double xPoint = Convert.ToDouble(Console.ReadLine());
        double yPoint = Convert.ToDouble(Console.ReadLine());
        double lenght = Math.Sqrt((xPoint * xPoint) + (yPoint * yPoint));
        if (lenght <= 2)
        {
            Console.WriteLine("yes {0:F2}",lenght);
        }
        else
        {
            Console.WriteLine("no {0:F2}",lenght);
        }
    }
}

