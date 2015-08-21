using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.SchoolClasses
{
    public class Student : Person, IComment
    {
        //fields
        private int classNumber;
        private string comment;
        
        //constructors
        public Student(string name, int classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }
        public Student(string name, int classNumber, string comment) : this(name, classNumber)
        {
            this.Comment = comment;
        }
        //encapsulation
        public int ClassNumber
        {
            get { return this.classNumber; }
            set { this.classNumber = value; }
        }
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        //methods
        public override string ToString()
        {
            return string.Format("{0} is number{1} in class; {1}", this.Name, this.ClassNumber, this.Comment);
        }
    }
}
