namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
                if (this.width < 0)
                {
                    throw new ArgumentException("The parameters must be positive numbers !");
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
                if (this.height < 0)
                {
                    throw new ArgumentException("The parameters must be positive numbers !");
                }

                    
            }
        }

        public abstract double CalculateSurface();
    }
}
