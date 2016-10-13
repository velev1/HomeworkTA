using System;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double side, double height)
        {
            this.Width = side;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return (Width * Height) / 2;
        }
    }
}
