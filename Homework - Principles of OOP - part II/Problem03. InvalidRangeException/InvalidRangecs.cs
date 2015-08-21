using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.InvalidRangeException
{
    public class InvalidRangecs<T> : ArgumentException
    {
        private T start;
        private T end;

        public InvalidRangecs(string msg, T start, T end, Exception innerEx)
            : base(msg, innerEx)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangecs(string msg, T start, T end)
            : this(msg, start, end, null)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start 
        {
            get { return this.start; }
            private set { this.start = value; }
        }

        public T End
        {
            get { return this.end; }
            private set { this.end = value; }
        }
    }
}
