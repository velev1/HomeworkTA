using System;

class TriangleSurfaceByThreeSides
{
    static void Main()
    {
        //a , b , c sides of the triangle
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        //half perimeter
        double p = (a + b + c) / 2;
        //Heron's formula for area
        double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        Console.WriteLine("{0:F2}",s);
    }
}

