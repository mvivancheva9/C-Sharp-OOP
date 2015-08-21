using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.StudentsAndWorkers
{
    class Student : Human
    {
        //fields
        private double grade;

        //constructors
        public Student (string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
        //encapsulation
        public double Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
        //methods
        public override string ToString()
        {
            return string.Format("Grade:[{0}] {1} {2}", this.Grade, this.FirstName, this.LastName);
        }
    }
}
