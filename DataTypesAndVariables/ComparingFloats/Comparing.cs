using System;

class Comparing
{
    static void Main()
    {
        double eps = 0.000001;
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double max = Math.Max(a, b);
        double min = Math.Min(a, b);
        double difference = max - min;
        if (difference >= eps)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}

