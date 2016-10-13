
namespace DefiningClassesPart2
{
    using System.Linq;
    using System;

    public struct  Point3D
    {
        private static readonly Point3D o = new Point3D() { X = 0, Y = 0, Z = 0};

        public static Point3D O
        {
            get
            {
                return o;
            }
        }


        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public override string ToString()
        {
            return String.Format("Coordinates({0}, {1}, {2})",X,Y,Z);
        }


        public static Point3D ParsePoint(string text)
        {
            //"Coordinates(0, 0, 3)"
            int OpenPar = text.IndexOf('(');
            double[] coord = text
                .Substring(OpenPar +  1, text.Length - OpenPar - 2)
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToArray();

            return new Point3D() { X = coord[0], Y = coord[1] , Z = coord[2]};
        }
    }
}
