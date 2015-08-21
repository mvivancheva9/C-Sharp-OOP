using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.SchoolClasses
{
    public class Teacher : Person, IComment
    {
        //fields
        private List<Disciplines> disciplines;
        private string comment;

        //constructors
        public Teacher(string name) : base(name)
        {
            this.disciplines = new List<Disciplines>();
        }
        public Teacher(string name, string comment) : this(name)
        {
            this.Comment = comment;
        }
        //encapsulation
        public List<Disciplines> Disciplines
        {
            get
            {
                return new List<Disciplines>(this.disciplines);
            }

        }
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public Disciplines Disciplines1
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
        public void AddDisciplineToTeacher(Disciplines discipline)
        {
            this.disciplines.Add(discipline);
        }
        
    }
}
