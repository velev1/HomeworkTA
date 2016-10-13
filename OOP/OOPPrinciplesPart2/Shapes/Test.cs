namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Test
    {
        static void Main()
        {
            var shapes = new List<Shape>();

            shapes.Add(new Rectangle(1, 5));
            shapes.Add(new Triangle(3, 5.2));
            shapes.Add(new Square(4));

            shapes.ForEach(
                shape => Console.WriteLine(
                   string.Format("{0} surface = {1}",
                   shape.GetType().Name,
                   shape.CalculateSurface()
                    )
                ));
        }
    }
}
