using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> allShapes = new List<Shape>()
            {
            new Triangle(2.3, 4.4),
            new Rectangle(3, 4),
            new Square(5)
            };
            PrintShapes(allShapes);
        }
        public static void PrintShapes(IEnumerable<Shape> allShapes)
        {
            //LINQ
            var printShapes =
                 from shape in allShapes
                 select shape;
            Console.WriteLine("Areas of different Shapes:");
            ToString(printShapes);
        }
        public static void ToString(IEnumerable<Shape> allShapes)
        {
            foreach (var shape in allShapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}
