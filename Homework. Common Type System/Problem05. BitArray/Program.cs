using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05.BitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray arr1 = new BitArray(59584748156896418);
            BitArray arr2 = new BitArray(848471448748457487);
            Console.WriteLine("The first array:");
            Console.WriteLine(arr1);
            Console.WriteLine("\nThe second array:");
            Console.WriteLine(arr2);
            Console.WriteLine("\nThe first array after the change on index 1:");
            arr1[1] = 0;
            Console.WriteLine(arr1);

            Console.Write("\nThe hashcode of the first array: ");
            Console.WriteLine(arr1.GetHashCode());

            Console.Write("\nCheck whether the two numbers are equal: ");
            Console.WriteLine(arr1 == arr2);

            Console.Write("\nCheck whether the two numbers are not equal: ");
            Console.WriteLine(arr1 != arr2);

            
        }
    }
}
