namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            :base(width)
        {
            this.Hieght = height;
        }

        public override double CalculateSurface()
        {
            double surface = (Hieght * Width) / 2;
            return surface;
        }
    }
}
