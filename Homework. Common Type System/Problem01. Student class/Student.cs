using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Student_class
{
    class Student : ICloneable, IComparable<Student>
    {
        //fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private string course;
        private Specialties specialty;
        private Universities university;
        private Faculties faculty;

        //constructors
        public Student (string firstName, string middleName, string lastName, string ssn, string permanentAddress, 
            string mobilePhone, string email, string course, Specialties specialty, Universities university, Faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }
        //encapsulation
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Ssn
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }
        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set { this.permanentAddress = value; }
        }
        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        public Specialties Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }
        public Universities University
        {
            get { return this.university; }
            set { this.university = value; }
        }
        public Faculties Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }
        //methods
        public override bool Equals(Object s)
        {
            var studentToCompare = s as Student;

            if (s == null) 
                return false;

            return this.FirstName == studentToCompare.FirstName &&
                   this.MiddleName == studentToCompare.MiddleName &&
                   this.LastName == studentToCompare.LastName &&
                   this.PermanentAddress == studentToCompare.PermanentAddress &&
                   this.Course == studentToCompare.Course &&
                   this.Email == studentToCompare.Email &&
                   this.Faculty == studentToCompare.Faculty &&
                   this.MobilePhone == studentToCompare.MobilePhone &&
                   this.Ssn == studentToCompare.Ssn &&
                   this.University == studentToCompare.University &&
                   this.Specialty == studentToCompare.Specialty;
        }

        public static bool operator ==(Student initialStudent, Student studentToCompare)
        {
            return initialStudent.Equals(studentToCompare); 
        }

        public static bool operator !=(Student initialStudent, Student studentToCompare)
        {
            return !(initialStudent == studentToCompare);
        }
        public override int GetHashCode()
        {
            return this.Ssn.GetHashCode() * 11 ^ this.MobilePhone.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Student: {0} {1} {2}", this.FirstName, this.LastName, this.University);
        }
        public object Clone()
        {
            Student clonedStudent = new Student
                (
                this.FirstName, 
                this.MiddleName,
                this.LastName, 
                this.Ssn, 
                this.PermanentAddress, 
                this.MobilePhone, 
                this.Email,
                this.Course, 
                this.Specialty,
                this.University,
                this.Faculty
                );
            return clonedStudent;
        }


        public int CompareTo(Student other)
        {
            int compareFirstName = this.FirstName.CompareTo(other.FirstName);
            int compareMiddleName = this.MiddleName.CompareTo(other.MiddleName);
            int compareLastName = this.LastName.CompareTo(other.LastName);
            int compareSsn = this.Ssn.CompareTo(other.Ssn);

            if (compareFirstName == 0)
            {
                if (compareMiddleName == 0)
                {
                    if (compareLastName == 0)
                    {
                        if (compareSsn == 0)
                        {
                            return 0;
                        }
                        else if (compareSsn < 0)
                        {
                            return -1;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                    else if (compareLastName < 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else if (compareMiddleName < 0)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else if (compareFirstName < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
