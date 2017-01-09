namespace Shapes
{
    public class Rectangle : Shape
    {

        public Rectangle(double width, double height)
            :base(width)
        {
            this.Hieght = height;
        }

        public override double CalculateSurface()
        {
            double surface = Width * Hieght;
            return surface;
        }
    }
}
