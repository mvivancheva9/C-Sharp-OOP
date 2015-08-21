using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Shapes
{
    class Square : Shape
    {
        //constructors
        public Square(double width)
            : base(width)
        {

        }
        //methods
        public override double CalculateSurface()
        {
            double area = (this.Width * this.Width);
            return area;
        }
        public override string ToString()
        {
            return string.Format("The area of square [{1}, {2}] is: {0}", this.CalculateSurface(),this.Width,this.Width);
        }
    }
}
