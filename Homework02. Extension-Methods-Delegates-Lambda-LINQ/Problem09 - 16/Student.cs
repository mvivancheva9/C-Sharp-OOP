using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09___16
{
    class Student
    {
        //FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
        //fields
        private string firstName;
        private string lastName;
        private string fN;
        private string tel;
        private string email;
        private List<int> marks;
        private Group groupNumber;

        //constructor
        public Student(string firstName, string lastName, string fN, string tel, string email, List<int> marks, Group groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }
        //encapsulation
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
        public string FN
        {
            get { return this.fN; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please fill a FN");
                }
                this.fN = value;
            }
        }
        public string Tel
        {
            get { return this.tel; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please fill a tel");
                }
                this.tel = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please fill an email");
                }
                this.email = value;
            }
        }
        public List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }
        public Group GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }

        public override string ToString()
        {
            string marksAsString = string.Join(", ", this.Marks.ToArray());
            return this.FirstName + " " + this.LastName + "\nStudent ID: " + this.FN + "\nNumber: " + this.Tel + "\nE-mail: " + this.Email + "\nMarks: " + marksAsString + "\nGroup Number: " + this.GroupNumber + "\n";
        }
    }
}
