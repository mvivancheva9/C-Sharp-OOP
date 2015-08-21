using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.SchoolClasses
{
    public class Class : IComment
    {
        //fields
        private string textID;
        private string comment;
        private List<Student> students;
        private List<Teacher> teachers;

        //constructors
        public Class(string textID)
        {
            this.TextID = textID;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }
        public Class(string textID, string comment)
            : this(textID)
        {
            this.Comment = comment;
        }
       
        //encapsulation
        public string TextID
        {
            get { return this.textID; }
            set { this.textID = value; }
        }
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }
        public List<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }

        }
        public List<Teacher> Teachers
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }

        }

        public Student Student
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Teacher Teacher
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        //methods
        public void AddStudentToAClass(Student student)
        {
            this.students.Add(student);
        }
        public void AddTeacherToAClass(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }
        public override string ToString()
        {
            StringBuilder listClasses = new StringBuilder();
            listClasses.AppendLine(TextID);
            if (this.Students.Count > 0)
            {
                listClasses.AppendLine(string.Format("   Students:"));
            }
            for (int i = 0; i < this.Students.Count; i++)
            {
                listClasses.AppendLine(string.Format("   * {0}; Class number: {1}; ", this.Students[i].Name, this.Students[i].ClassNumber));

                if (this.Students[i].Comment != null)
                {
                    listClasses.AppendLine(string.Format("     Comments: {0}.", this.Students[i].Comment));
                }
            }

            if (this.Teachers.Count > 0)
            {
                listClasses.AppendLine(string.Format("   Teachers:"));
            }
            for (int i = 0; i < this.Teachers.Count; i++)
            {
                listClasses.AppendLine(string.Format("   * {0}; ", this.Teachers[i].Name));

                if (this.Teachers[i].Comment != null)
                {
                    listClasses.AppendLine(string.Format("     Comments: {0}.", this.Teachers[i].Comment));
                }
                for (int j = 0; j < this.Teachers[i].Disciplines.Count; j++)
                {
                    if (this.Teachers[i].Disciplines.Count > 0)
                    {
                        listClasses.AppendLine(string.Format("     + Disciplines:"));
                    }
                    listClasses.Append(string.Format("       {0}", this.Teachers[i].Disciplines[j].DisciplineName));

                    if (this.Teachers[i].Disciplines[j].Comment != null)
                    {
                        listClasses.AppendLine(string.Format("       ({0})", this.Teachers[i].Disciplines[j].Comment));
                    }
                    else
                    {
                        listClasses.AppendLine();
                    }
                }
            }

            

            return listClasses.ToString();
        }
    }
}
