using System;

namespace Shapes
{
    public class Square : Shape
    {
        public Square(double side)
        {
            this.Width = side;
            this.Height = side;
        }

        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }
}
