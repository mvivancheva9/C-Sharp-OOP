using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.SchoolClasses
{
    public class Disciplines : IComment
    {
        //fields
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;
        private string comment;
        
        //constructors
        public Disciplines(string disciplineName, int numberOfLectures, int numberOfExercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }
        public Disciplines(string disciplineName, int numberOfLectures, int numberOfExercises, string comment) : this(disciplineName, numberOfLectures, numberOfExercises)
        {
            this.Comment = comment;
        }
        //encapsulation
        public string DisciplineName
        {
            get { return this.disciplineName; }
            set { this.disciplineName = value; }
        }
        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set { this.numberOfLectures = value; }
        }
        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set { this.numberOfExercises = value; }
        }
        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        //methods
        
    }
}
