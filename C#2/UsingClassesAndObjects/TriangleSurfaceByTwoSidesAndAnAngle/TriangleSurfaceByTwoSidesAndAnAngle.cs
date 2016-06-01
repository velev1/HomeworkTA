using System;

class TriangleSurfaceByTwoSidesAndAnAngle
{
    static void Main()
    {
        //sides of treangle
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        //the angle between the sides
        double angle = double.Parse(Console.ReadLine());
        double radians = angle * (Math.PI / 180);
        double s = 1 / 2.0 * a * b * Math.Sin(radians);

        Console.WriteLine("{0:F2}",s);
    }
}

