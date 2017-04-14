namespace ClassSize
{
    using System;

    public class Size
    {
        private double width;
        private double heigth;

        public Size(double width, double heigth)
        {
            this.Width = width;
            this.Heigth = heigth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.width = value;
            }
        }

        public double Heigth
        {
            get
            {
                return this.heigth;
            }

            private set
            {
                this.heigth = value;
            }
        }

        public static Size GetRotatedSize(Size s, double angleInRadians)
        {
            double calcCosWidth = Math.Abs(Math.Cos(angleInRadians)) * s.Width;
            double calcSinHeigth = Math.Abs(Math.Sin(angleInRadians)) * s.Heigth;
            double calcSinWidth = Math.Abs(Math.Sin(angleInRadians)) * s.Width;
            double calcCosHeigth = Math.Abs(Math.Cos(angleInRadians)) * s.Heigth;

            var sizeAfterRotation = new Size(calcCosWidth + calcSinHeigth, calcSinWidth + calcCosHeigth);

            return sizeAfterRotation;
        }
    }
}
