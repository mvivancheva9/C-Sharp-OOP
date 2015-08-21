using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_04_05
{
    class StudentTest
    {
        static void Main(string[] args)
        {
            Student[] arrStudents = 
            {
            new Student("Ivan", "Angelov", 25),
            new Student("Dragan", "Ivanov", 27),
            new Student("Angel", "Ivanov", 26),
            new Student("Ivan", "Draganov", 24),
            new Student("Dragan", "Angelov", 17),
            new Student("Angel", "Draganov", 16)
            };
            FirstBeforeLastName(arrStudents);//problem 03
            StudentsWithAreRange(arrStudents);//problem 04
            StudentsOrderByName(arrStudents);//problem 05 LINQ & Lambda Expressions
        }
        public static void FirstBeforeLastName(IEnumerable<Student> arrStudents)// problem 03
        {
            var firstBeforeLastName =
                 from student in arrStudents
                 where student.FirstName.CompareTo(student.LastName) < 0
                 select student;
            Console.WriteLine("Students with first names before last names:");
            ToString(firstBeforeLastName);
        }

        public static void StudentsWithAreRange(IEnumerable<Student> arrStudents)// problem 04
        {
            var studentsWithAreRange =
                 from student in arrStudents
                 where student.Age >= 18 && student.Age <= 24
                 select student;
            Console.WriteLine("\nStudents with age in the range [18..24]:");
            ToString(studentsWithAreRange);
        }
        public static void StudentsOrderByName(IEnumerable<Student> arrStudents)// problem 05 LINQ & Lambda Expressions
        {
            //LINQ
            var studentsOrderByNameLINQ =
                 from student in arrStudents
                 orderby student.FirstName descending, student.LastName descending
                 select student;
            Console.WriteLine("\nStudents, ordered by first and last name, using LINQ:");
            ToString(studentsOrderByNameLINQ);

            //Lambda
            var studentsOrderByNameLambda =
                arrStudents.OrderByDescending(student => student.FirstName).
                ThenByDescending(student => student.LastName).
                Select(student => student);
            Console.WriteLine("\nStudents, ordered by first and last name, using Lambda Expressions:");
            ToString(studentsOrderByNameLambda);

        }
        public static void ToString(IEnumerable<Student> arrStudents)
        {
            foreach (var student in arrStudents)
            {
                Console.WriteLine(student);
            }
        }
            
    }
}
