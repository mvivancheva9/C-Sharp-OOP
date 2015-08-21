using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    public static class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double xCalculation = (secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X);
            double yCalculation = (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y);
            double zCalculation = (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z);

            double distance = Math.Sqrt(xCalculation + yCalculation + zCalculation);

            return distance;
        }
    }
}
