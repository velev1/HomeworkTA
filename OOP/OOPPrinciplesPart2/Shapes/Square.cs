namespace Shapes
{
    public class Square : Shape
    {
        public Square(double side)
            :base(side)
        {

        }

        public override double CalculateSurface()
        {
            double surface = Width * Width;
            return surface;
        }
    }
}
