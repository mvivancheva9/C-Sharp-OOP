using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.IEnumerable_extensions
{
    public static class INumerableExtransions
    {
        public static T Sum<T>(this IEnumerable<T> elements) where T : struct
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Empty Set");
            }
            T result = (dynamic)0;

            foreach (T item in elements)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> elements) where T : struct
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Empty Set");
            }

            T result = (dynamic)1;

            foreach (T item in elements)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> elements) where T : struct
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Empty Set");
            }

            T min = elements.First();

            foreach (T item in elements)
            {
                if (item < (dynamic)min)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> elements) where T : struct
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Empty Set");
            }

            T max = elements.First();

            foreach (T item in elements)
            {
                if (item > (dynamic)max)
                {
                    max = item;
                }
            }
            return max;
        }

        public static double Average<T>(this IEnumerable<T> elements) where T : struct
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Empty Set");
            }

            return (dynamic)elements.Sum() / elements.Count();
        }
    }
}
