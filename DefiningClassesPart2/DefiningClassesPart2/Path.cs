using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
   public class Path
   {
       List<Point3D> pointSequence;

       public Path()
       {
           this.pointSequence = new List<Point3D>();
       }
       public int Count
       {
           get { return this.pointSequence.Count; }
       }
       public Point3D this[int index]
       {
           get
           {
               if (index < 0 || index > pointSequence.Count)
               {
                   throw new ArgumentException("Invalid input");
               }
               return this.pointSequence[index];
           }
           set
           {
               if (index < 0 || index > pointSequence.Count)
               {
                   throw new ArgumentException("Invalid input");
               }
               this.pointSequence[index] = value;
           }
       }
       public void AddPoint(Point3D point)
       {
           this.pointSequence.Add(point);
       }
       public override string ToString()
       {
           return String.Join(Environment.NewLine, this.pointSequence);
       }
   }
}
