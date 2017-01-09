namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;

        private double height;


        public Shape(double width)
        {
            this.Width = width;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the side must be greater than zero.");
                }

                this.width = value;
            }

        }

        public double Hieght
        {
            get
            {
                return this.height;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the side must be greater than zero.");
                }

                this.height = value;
            }
        }


        public abstract double CalculateSurface();
    }
}
