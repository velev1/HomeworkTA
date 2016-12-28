namespace Points
{
    using System;
    public static class VectorMagnitude3D
    {

        public static double MagnitudeByPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double magnitude = 0;

            magnitude = Math.Sqrt(((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X))
                                + ((secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y))
                                + ((secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z)));

            return magnitude;
        }
    }
}
