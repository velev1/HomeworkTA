using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double d = (b * b) - (4 * a * c);
        double sqrtD = Math.Sqrt(d);
        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (d == 0)
        {
            Console.WriteLine("{0:F2}", (-b) / (2 * a));
        }
        else
        {
            double x1 = ((-b) - sqrtD) / (2 * a);
            double x2 = ((-b) + sqrtD) / (2 * a);
            
            Console.WriteLine("{0:F2}", Math.Min(x1, x2));
            Console.WriteLine("{0:F2}", Math.Max(x1, x2));
        }
    }
}

