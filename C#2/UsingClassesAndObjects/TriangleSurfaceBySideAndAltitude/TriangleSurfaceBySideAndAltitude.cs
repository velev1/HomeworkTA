﻿using System;

class TriangleSurfaceBySideAndAltitude
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        double altitude = double.Parse(Console.ReadLine());

        double s = (side * altitude) / 2;

        Console.WriteLine("{0:F2}",s);
    }
}

