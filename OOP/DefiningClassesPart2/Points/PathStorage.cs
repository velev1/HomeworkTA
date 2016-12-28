namespace Points
{
    using System.IO;
    using System.Collections.Generic;
    public static class PathStorage
    {
        public static void SaveToPath(string path, Point3D point)
        {
            if (File.Exists(path) == true)
            {
                using (StreamWriter file = new StreamWriter(path, true))
                {
                    file.WriteLine(point.ToString());
                }
            }
            else
            {
                throw new FileNotFoundException(string.Format("The file \"{0}\" can not be found !", path));
            }

        }

        public static List<string> LoadPath(string filePath)
        {
            if (File.Exists(filePath) == true)
            {
                var lines = new List<string>();
                string line;

                StreamReader file = new StreamReader(filePath);
                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                file.Close();

                return lines;
            }
            else
            {
                throw new FileNotFoundException(string.Format("The file \"{0}\" can not be found !", filePath));
            }
        }

    }
}
