using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04.Person_class
{
    public class Person
    {
        //fields
        private string name;
        private int? age;
        //constructors
        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }
        public Person(string name, int age) : this(name)
        {
            this.Age = age;
        }

        //encapsulation
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
             public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
      
        //methods
             public override string ToString()
             {
                 if (this.Age == null)
                 {
                     return string.Format("{0} has not entered age information", this.Name);
                 }
                 return string.Format("{0} is {1} years old", this.Name, this.Age);
             }
    }
}
