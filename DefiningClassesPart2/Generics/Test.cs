using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Test
    {
        static void Main(string[] args)
        {
            GenericList<int> test = new GenericList<int>(3);

            test.Add(1);
            test.Add(2); 
            test.Add(3); 
            test.Add(4); 
            test.Add(5);
            test.Insert(1, 33); 
            test.Insert(0, 22); 
            test.Insert(6, 66);
            Console.WriteLine("List:");
            Console.WriteLine(test);
            Console.WriteLine("Min: {0}", test.Min());
            Console.WriteLine("Max: {0}", test.Max());
            test.RemoveAt(4);
            Console.WriteLine(test);
            Console.WriteLine("Position of '1' = {0}", test.IndexOf(1)); 
            Console.WriteLine("Position of '33' = {0}", test.IndexOf(33));

           

        }
    }
}
