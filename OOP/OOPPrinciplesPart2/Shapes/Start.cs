namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class Start
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            Shape t = new Triangle(2.3, 3.4);
            Shape s = new Square(3);
            Shape r = new Rectangle(5, 7);
            
            shapes.Add(t);
            shapes.Add(s);
            shapes.Add(r);

            foreach (var item in shapes)
            {
                Console.WriteLine("The surface of the {0} is: {1}" ,item.GetType().Name,item.CalculateSurface());
            }
        }
    }
}
