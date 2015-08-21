using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_04_05
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please fill a name");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please fill a name");
                }
                    this.lastName = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                
                    this.age = value;
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " [" + this.Age + " years]";
        }
    }
}
