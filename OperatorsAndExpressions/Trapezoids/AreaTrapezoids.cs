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

