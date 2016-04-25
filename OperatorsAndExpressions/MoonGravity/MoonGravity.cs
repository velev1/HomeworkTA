using System;

class MoonGravity
{
    static void Main()
    {
        double weight = Convert.ToDouble(Console.ReadLine());
        weight = weight * (17 / 100.0);
        Console.WriteLine("{0:F3}", weight);
    }
}
