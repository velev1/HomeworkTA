namespace Points
{
    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public Point3D O
        {
            get
            {
                return Point3D.o;
            }
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}, Z={2}", X, Y, Z);
        }
    }
}
