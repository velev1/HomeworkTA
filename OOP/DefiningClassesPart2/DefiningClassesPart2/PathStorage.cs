
namespace DefiningClassesPart2
{
    using System.IO;
    public static class PathStorage
    {
        public static void SavePath(Path path, string filePath)
        {
            using (var streamWriter = new StreamWriter(filePath))
            {
                foreach (var point in path)
                {
                    streamWriter.WriteLine(point); 
                }
            }
        }

        public static Path LoadPath(string filePath)
        {

            var path = new Path();
            using (var streamReader = new StreamReader(filePath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var point = Point3D.ParsePoint(line);
                    path.AddPoint(point);
                }
            }
            return path;
        }
    }
}
