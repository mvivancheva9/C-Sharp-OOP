using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMTest
{
    class Display
    {
        private double? displaySize;
        private int? displayNumColors;

        //constructors
        public Display()
        {
            this.DisplaySize = null;
            this.DisplayNumColors = null;
        }
        public Display(double displaySize, int displayNumColors)
        {
            this.DisplaySize = displaySize;
            this.DisplayNumColors = displayNumColors;
        }

        //encapsulation
        public double? DisplaySize
        {
            get { return this.displaySize; }
            set { this.displaySize = value; }
        }
        public int? DisplayNumColors
        {
            get { return this.displayNumColors; }
            set { this.displayNumColors = value; }
        }

        //methods
        public override string ToString()
        {
            return string.Format("Display Size: {0}, Display Colors: {1}", displaySize, displayNumColors);
        }
    }
}
