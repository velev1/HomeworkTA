namespace Points
{
    using System;
    using System.Collections.Generic;

    public class Start
    {
        static void Main()
        {
            //set two 3D points
            Point3D firstPoint = new Point3D(1, 2, 3);
            Point3D secondPoint = new Point3D(4, 5, 6);

            //make instanse of Path Object and add three points to it.
            Path pointSequence = new Path();
            pointSequence.AddToPath(firstPoint);
            pointSequence.AddToPath(secondPoint);
            //using static property O which retursn (0,0,0)
            pointSequence.AddToPath(firstPoint.O);

            //Get the path of points by GetPath method which returns List<Point3D> and print the path
            var path = new List<Point3D>();
            path = pointSequence.GetPath();
            foreach (var point in path)
            {
                Console.WriteLine(point);
            }

            //Add new line in the PointCollection.txt  file
            string filePath = @"..\..\PointCollection.txt";
            PathStorage.SaveToPath(filePath, firstPoint);

            //Calculate the distanse between two 3D points
            Console.WriteLine("Distance = " + VectorMagnitude3D.MagnitudeByPoints(firstPoint, secondPoint));

            //Load and display the content of the file PointCollection.txt
            var fileContent = PathStorage.LoadPath(filePath);
            foreach (var line in fileContent)
            {
                Console.WriteLine(line);
            }
        }
    }
}

