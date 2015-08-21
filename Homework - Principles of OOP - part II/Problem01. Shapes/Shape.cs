using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Shapes
{
    abstract class Shape
    {
        //fields
        private double width;
        private double height;

        //constructors
        public Shape(double width)
        {
            this.Width = width;
        }
        public Shape(double width, double height) : this(width)
        {
            this.Height = height;
        }
        //encapsulation
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative");
                }
                this.height = value;
            }
        }
        //methods
        public virtual double CalculateSurface()
        {
            return 0.0;
        }
    }
}
