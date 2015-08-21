using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05.BitArray
{
    public class BitArray : IEnumerable
    {
        //fields
        private ulong number;

        
        //constructors
        public BitArray(ulong number)
        {
            this.Number = number;
        }
        //encapsulation
        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        //methods
        public int this[int pos]
        {
            get
            {
                if (pos < 0 || pos > 63)
                {
                    throw new ArgumentOutOfRangeException("Out of range");
                }

                return (int)((this.number >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos > 63)
                {
                    throw new ArgumentOutOfRangeException("Out of range");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Enter 0 or 1");
                }
                if (value == 1)
                {
                    this.number = this.number | ((ulong)1 << pos);
                }
                else
                {
                    this.number = this.number & (~((ulong)1 << pos));
                }
            }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 63; i >= 0; i--)
            {
                builder.Append((this.Number >> i) & 1);
            }

            return builder.ToString();
        }
        public override bool Equals(object obj)
        {
            var objAsNum = obj as BitArray;

            return this.Number.Equals(objAsNum.Number);
        }
        public static bool operator == (BitArray first, BitArray second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray first, BitArray second)
        {
            return !(first.Equals(second));
        }
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.number.GetHashCode();
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
