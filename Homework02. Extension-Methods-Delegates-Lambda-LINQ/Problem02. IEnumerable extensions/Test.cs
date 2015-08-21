using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.IEnumerable_extensions
{
    class Test
    {
        static void Main(string[] args)
        {
            IEnumerable<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Check for integers");
            Console.WriteLine("Sum: {0}", list.Sum());
            Console.WriteLine("Product: {0}", list.Product());
            Console.WriteLine("Min: {0}", list.Min());
            Console.WriteLine("Max: {0}", list.Max());
            Console.WriteLine("Average: {0}", list.Average());
            Console.WriteLine();

            Console.WriteLine("Check for doubles");
            IEnumerable<double> list2 = new List<double>() { 1.1, 2.2, 3.2, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 };
            Console.WriteLine("Sum: {0}", list2.Sum());
            Console.WriteLine("Product: {0}", list2.Product());
            Console.WriteLine("Min: {0}", list2.Min());
            Console.WriteLine("Max: {0}", list2.Max());
            Console.WriteLine("Average: {0}", list2.Average());
        }
    }
}
