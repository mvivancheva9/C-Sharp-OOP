using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09___16
{
    class StudentMain
    {
        static void Main(string[] args)
        {
            List<Student> listStudents = new List<Student>()
            {
                new Student("Ivan", "Angelov", "100006023", "02456789", "ivan_angelov@abv.bg", new List<int> { 5, 6 }, new Group(1, "Mathematics")),
                new Student("Dragan", "Ivanov", "100056896", "02123456", "dragan_ivanov@gmail.com", new List<int> { 4, 5 }, new Group(2, "Informatics")),
                new Student("Angel", "Ivanov", "100006545", "064895623", "angel_ivanov@abv.bg", new List<int> { 2, 2, 3 }, new Group(1, "Biology")),
                new Student("Ivan", "Draganov", "10045022", "064895478", "ivan_gradanov@abv.bg", new List<int> { 4, 5, 6 }, new Group(2, "Astronomy")),
                new Student("Dragan", "Angelov", "100022566", "02655655", "dragan_angelov@gmail.com", new List<int> { 4 }, new Group(1, "Mathematics")),
                new Student("Angel", "Draganov", "10055022", "02895478", "angel_gradanov@abv.bg", new List<int> { 4, 4, 6 }, new Group(2, "Informatics")),
                
            };
            StudentsOrderByName(listStudents);//problem 09 & 10
            StudentsByEmail(listStudents);// problem 11
            StudentsByPhone(listStudents);// problem 12
            ExcellentMarkStudents(listStudents);// problem 13
            StudentsWithTwoMarks(listStudents);//problem 14
            StudentsFrom2006(listStudents);//problem 15
            StudentsFromMathematics(listStudents);//problem 16
            GroupByBroupNumber(listStudents);//problem 18
            GroupByBroupNumberLambda(listStudents);//problem 19
        }
        public static void StudentsOrderByName(IEnumerable<Student> listStudents)// problem 09 & 10
        {
            //LINQ
            var studentsOrderByNameLINQ =
                 from student in listStudents
                 where student.GroupNumber.GroupNumber == 2
                 orderby student.FirstName
                 select student;
            Console.WriteLine("Students from group 2, ordered by first name, using LINQ:");
            ToString(studentsOrderByNameLINQ);
            //Lambda
            var studentsOrderByNameLambda =
                listStudents.Where(student => student.GroupNumber.GroupNumber == 2).
                OrderBy(student => student.FirstName).
                Select(student => student);
            Console.WriteLine("\nStudents from group 2, ordered by first name, using Lambda:");
            ToString(studentsOrderByNameLambda);
        }
        public static void StudentsByEmail(IEnumerable<Student> listStudents)// problem 11
        {
            //LINQ
            var studentsByEmailLINQ =
                 from student in listStudents
                 where student.Email.Contains("abv.bg")
                 select student;
            Console.WriteLine("Students whose e-mail contains 'abv.bg', using LINQ:");
            ToString(studentsByEmailLINQ);
            //Lambda
            var studentsByEmailLambda =
                listStudents.Where(student => student.Email.Contains("abv.bg")).
                Select(student => student);
            Console.WriteLine("\nStudents whose e-mail contains 'abv.bg', using Lambda:");
            ToString(studentsByEmailLambda);
        }
        public static void StudentsByPhone(IEnumerable<Student> listStudents)// problem 12
        {
            //LINQ
            var studentsByPhoneLINQ =
                 from student in listStudents
                 where student.Tel.Contains("02")
                 select student;
            Console.WriteLine("Students from Sofia, using LINQ:");
            ToString(studentsByPhoneLINQ);
            //Lambda
            var studentsByPhoneLambda =
                listStudents.Where(student => student.Tel.Contains("02")).
                Select(student => student);
            Console.WriteLine("\nStudents from Sofia, using Lambda:");
            ToString(studentsByPhoneLambda);
        }

        public static void ExcellentMarkStudents(IEnumerable<Student> listStudents)// problem 13
        {
            var excellentMarkStudents = 
                from student in listStudents
                where student.Marks.Contains(6)
                select new {FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };
            Console.WriteLine("\nStudents with at least one excellent mark: ");
            foreach (var student in excellentMarkStudents)
            {
                Console.WriteLine(student.FullName + " - Marks: " + string.Join(" ", student.Marks));
            }
            Console.WriteLine();
        }
        public static void StudentsWithTwoMarks(IEnumerable<Student> listStudents)// problem 14
        {
            var studentsWithTwoMarks = 
                listStudents.Where(student => student.Marks.Count(x => x == 2) == 2).
                Select (student => new  
                { 
                    FullName = student.FirstName + " " + student.LastName, Marks = student.Marks 
                });
            Console.WriteLine("\nStudents with 2 marks '2': ");
            foreach (var student in studentsWithTwoMarks)
            {
                Console.WriteLine(student.FullName + " - Marks: " + string.Join(" ", student.Marks));
            }
            Console.WriteLine();
        }
        public static void StudentsFrom2006(IEnumerable<Student> listStudents)// problem 15
        {
            var studentsFrom2006 =
                listStudents.Where(student => student.FN.Substring(4, 2) == "06").
                Select(student => new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    FN = student.FN
                });
            Console.WriteLine("\nStudents from 2006: ");
            foreach (var student in studentsFrom2006)
            {
                Console.WriteLine(student.FullName + " - Student ID: " + string.Join(" ", student.FN));
            }
            Console.WriteLine();
        }
        public static void StudentsFromMathematics(IEnumerable<Student> listStudents)// problem 16
        {
            var studentsFromMathematics =
                listStudents.Where(student => student.GroupNumber.DepartmentName == "Mathematics").
                Select(student => new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    GroupNumber = student.GroupNumber
                });
            Console.WriteLine("\nStudents from the Mathematics Department: ");
            foreach (var student in studentsFromMathematics)
            {
                Console.WriteLine(student.FullName + " - Department: " + string.Join(" ", student.GroupNumber));
            }
            Console.WriteLine();
        }
        public static void GroupByBroupNumber(IEnumerable<Student> listStudents)// problem 18
        {
            var groupedStudents =
                from student in listStudents
                group student by student.GroupNumber.GroupNumber into groups
                select new
                {
                    Group = groups.Key,
                    Students = groups.ToList()
                };


            foreach (var grouped in groupedStudents)
            {
                Console.WriteLine("\nGroup by LINQ: {0}\n{1}", grouped.Group,
                    string.Join("\r\n\r", grouped.Students));
            }
        }
        public static void GroupByBroupNumberLambda(IEnumerable<Student> listStudents)// problem 18
        {
            var groupedStudentsLambda = listStudents.GroupBy(x => x.GroupNumber.GroupNumber,
                (groupNumber, students) => new { Group = groupNumber, Students = students });


            foreach (var grouped in groupedStudentsLambda)
            {
                Console.WriteLine("\nGroup by Lambda: {0}\n{1}", grouped.Group,
                    string.Join("\r\n\r", grouped.Students));
            }
        }
        public static void ToString(IEnumerable<Student> listStudents)
        {
            foreach (var student in listStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
