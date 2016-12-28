namespace Points
{
    using System.Collections.Generic;
    public class Path
    {
        public List<Point3D> pointSequence;

        public Path()
        {
            pointSequence = new List<Point3D>();
        }

        public void AddToPath(Point3D point)
        {
            pointSequence.Add(point);
        }

        public List<Point3D> GetPath()
        {
            return pointSequence;
        }
    }
}
