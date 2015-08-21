using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.SchoolClasses
{
    public class Person
    {
        //fields
        private string name;

        //constructors
        public Person (string name)
        {
            this.Name = name;
        }
        //encapsulation
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //methods
    }
}
