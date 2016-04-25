using System;

class NumberComparer
{
    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double max = Math.Max(a, b);

        Console.WriteLine(max);
    }
}

