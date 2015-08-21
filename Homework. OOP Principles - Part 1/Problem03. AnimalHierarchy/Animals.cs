using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.AnimalHierarchy
{
    public abstract class Animals : ISound
    {
        //fields
        private int age;
        private string name;
        private Gender sex;

        //constructors
        public Animals(int age, string name)
        {
            this.Name = name;
            this.Age = age;
        }
        public Animals(int age, string name, Gender sex)
            : this(age, name)
        {
            this.Sex = sex;
        }
        //encapsulation
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Gender Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        //methods
        public override string ToString()
        {
            return string.Format("{0} is {1} years old {2}", this.Name, this.Age, this.Sex);
        }
        public abstract string MakeSound();
    }
}
