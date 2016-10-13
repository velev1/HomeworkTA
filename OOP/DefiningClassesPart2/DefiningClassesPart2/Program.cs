namespace DefiningClassesPart2
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point3D { X = 1, Y = 2, Z = 3 };
            Console.WriteLine(point);

            Console.WriteLine(Point3D.O);

            var distance = DisstanceBtwPoints.calculateDistance(point, Point3D.O);
            Console.WriteLine(distance);

            var path = new Path();

            for (int i = 0; i < 10; i++)
            {
                path.AddPoint(new Point3D() { X = i, Y = i * 2, Z = i + 3 });
            }

            PathStorage.SavePath(path , "../../path.txt");
            var PathFromFile =  PathStorage.LoadPath("../../path.txt");

            foreach (var p  in PathFromFile)
            {
                Console.WriteLine(p);
            }

        }
    }
}
