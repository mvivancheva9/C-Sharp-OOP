using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Shapes
{
    class Rectangle: Shape
    {
        //constructors
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }
        //methods
        public override double CalculateSurface()
        {
            double area = (this.Width * this.Height);
            return area;
        }
        public override string ToString()
        {
            return string.Format("The area of rectangle [{1}, {2}] is: {0}", this.CalculateSurface(), this.Width, this.Height);
        }
    }
}
