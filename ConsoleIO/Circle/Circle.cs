﻿using System;

class Circle
{
    static void Main()
    {
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("{0:F2} {1:F2}",2*Math.PI*r,Math.PI*r*r);
    }
}

