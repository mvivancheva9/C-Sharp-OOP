using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Shapes
{
    class Triangle : Shape
    {
        //constructors
        public Triangle(double width, double height) : base(width, height)
        {

        }
        //methods
        public override double CalculateSurface()
        {
            double area = (this.Width * this.Height) / 2;
            return area;
        }
        public override string ToString()
        {
            return string.Format("The area is of the triangle [{1}, {2}] is: {0}", this.CalculateSurface(), this.Width, this.Height);
        }
    }
}
