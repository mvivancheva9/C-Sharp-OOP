using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.StringBuilderSubstring
{
        public static class Extension
        {
            public static StringBuilder Substring(this StringBuilder value, int startIndex, int length)
            {
                return new StringBuilder(value.ToString(), startIndex, length, value.Capacity);
            }
        }
}
