using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(1, 2, 3);
            Point3D p2 = new Point3D(4, 5, 6);

            
            Path points = new Path();

            points.AddPoint(p1);
            points.AddPoint(p2);
            Console.WriteLine(points);
            Console.WriteLine("Distance:");
            Console.WriteLine("{0:F2}", Distance.CalculateDistance(p1, p2));

            PathStorage.Save(points, "Path.txt");
        }
    }
}
