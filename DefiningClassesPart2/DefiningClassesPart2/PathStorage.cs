using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public class PathStorage
    {
        public static void Save(Path points, string filePath)
        {
            File.WriteAllText(filePath, points.ToString());
        }

        public static Path Load(string file)
        {
            Path path3D = new Path();
            string[] pointsFromText = File.ReadAllText(file).Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < pointsFromText.Length; i++)
            {
                string[] coordinates = pointsFromText[i].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                path3D.AddPoint(new Point3D(int.Parse(coordinates[1]), int.Parse(coordinates[3]), int.Parse(coordinates[5])));
            }

            return path3D;
        }
    }
}
