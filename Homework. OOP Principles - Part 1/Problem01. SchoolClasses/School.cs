using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.SchoolClasses
{
    public class School
    {
        //fields
        private string schoolName;
        private List<Class> classes;

        //constructors
        public School (string schoolName)
        {
            this.SchoolName = schoolName;
            this.classes = new List<Class>();
        }
        //encapsulation
        public string SchoolName
        {
            get { return this.schoolName; }
            set { this.schoolName = value; }
        }
        public List<Class> Classes
        {
            get
            {
                return new List<Class>(this.classes);
            }
        }

        public Class Class
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
        public void AddClass(Class newClass)
        {
            this.classes.Add(newClass);
        }
        public override string ToString()
        {
            return string.Format("The school name is: {0}", this.SchoolName);
        }
    }
}