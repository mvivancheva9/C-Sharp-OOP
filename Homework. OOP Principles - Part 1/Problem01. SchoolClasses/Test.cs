using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.SchoolClasses
{
    class Test
    {
        static void Main(string[] args)
        {
            List<School> listSchools = new List<School>();
            School school1 = new School("American College");
            listSchools.Add(school1);

            Class class1 = new Class("9A", "The best class ever");
            Class class2 = new Class("9B");

            school1.Classes.Add(class1);
            school1.Classes.Add(class2);

            Student student1 = new Student("Ivan Ivanov", 13, "nice boy");
            Student student2 = new Student("Draganka Ivanova", 7);

            class1.AddStudentToAClass(student1);
            class1.AddStudentToAClass(student2);


            Disciplines discipline1 = new Disciplines("Math", 6, 9);
            Disciplines discipline2 = new Disciplines("Inf", 10, 12);

            Teacher teacher1 = new Teacher("Bogdan Bogdanov", "Best teacher ever");
            teacher1.AddDisciplineToTeacher(discipline1);
            Teacher teacher2 = new Teacher("Bogdana Ivanova");
            teacher2.AddDisciplineToTeacher(discipline1);
            teacher2.AddDisciplineToTeacher(discipline2);

            class1.AddTeacherToAClass(teacher1);
            class1.AddTeacherToAClass(teacher2);
            class2.AddTeacherToAClass(teacher2);

            Console.WriteLine("{0}. Classes:", school1);
            Console.WriteLine(" * {0}", class1);
            Console.WriteLine(" * {0}", class2);
            
        }
        public static void ListClasses(List<School> listSchools)
        {
            var classList =
                from classID in listSchools
                select classID.Classes;
            Console.WriteLine("List of Classes: {");
             }
        public static void ToString(IEnumerable<School> listClasses)
        {
            foreach (var classID in listClasses)
            {
                Console.WriteLine("{0}", classID);
            }
        }
    }
}
