using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04.Person_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ivan Ivanov");
            Person person2 = new Person("Dragan Draganov", 26);

            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
