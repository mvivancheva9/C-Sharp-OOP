using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.StudentsAndWorkers
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Worker> listWorkers = new List<Worker>();

            listWorkers.Add(new Worker("Ivan", "Ivanov", 1200.60, 60));
            listWorkers.Add(new Worker("Dragan", "Ivanov", 1220.60, 80));
            listWorkers.Add(new Worker("Petkan", "Ivanov", 1490.60, 40));
            listWorkers.Add(new Worker("Ivanka", "Ivanova", 2800.60, 60));
            listWorkers.Add(new Worker("Draganka", "Ivanova", 4200.60, 80));
            listWorkers.Add(new Worker("Petkanka", "Ivanova", 6200.60, 40));
            listWorkers.Add(new Worker("Ivanka", "Draganova", 8200.60, 50));
            listWorkers.Add(new Worker("Ivanka", "Petkanova", 6200.60, 60));
            listWorkers.Add(new Worker("Dragan", "Petkanov", 1000.60, 80));
            listWorkers.Add(new Worker("Petkan", "Draganov", 8900.60, 60));


            List<Student> listStudents = new List<Student>();

            listStudents.Add(new Student("Ivan", "Ivanov", 3.66));
            listStudents.Add(new Student("Dragan", "Ivanov", 2.66));
            listStudents.Add(new Student("Petkan", "Ivanov", 3.33));
            listStudents.Add(new Student("Ivanka", "Ivanova", 3.66));
            listStudents.Add(new Student("Draganka", "Ivanova", 3.33));
            listStudents.Add(new Student("Petkanka", "Ivanova", 2.66));
            listStudents.Add(new Student("Ivanka", "Draganova", 3.66));
            listStudents.Add(new Student("Ivanka", "Petkanova", 3.33));
            listStudents.Add(new Student("Dragan", "Petkanov", 2.66));
            listStudents.Add(new Student("Petkan", "Draganov", 3.66));

            List<Human> allPeople = new List<Human>();
            allPeople.AddRange(listStudents);
            allPeople.AddRange(listWorkers);

            StudentsOrderByName(listStudents);
            WorkersOrderByMoneyPerHour(listWorkers);
            PeopleOrderByName(allPeople);
        }

        public static void StudentsOrderByName(IEnumerable<Student> listStudents)//order by grade ascending
        {
            //LINQ
            var studentsOrderByGrade =
                 from student in listStudents
                 orderby student.Grade
                 select student;
            Console.WriteLine("Students ordered by grade:");
            ToString(studentsOrderByGrade);
        }
        public static void WorkersOrderByMoneyPerHour(IEnumerable<Worker> listWorkers)//order by money per hour
        {
            //LINQ
            var workersOrderByMoneyPerHour =
                 from worker in listWorkers
                 orderby worker.MoneyPerHour() descending
                 select worker;
            Console.WriteLine("\nWorkers ordered by earned money per hour:");
            ToString(workersOrderByMoneyPerHour);
        }
        public static void PeopleOrderByName(IEnumerable<Human> allPeople)//order by name ascending
        {
            //LINQ
            var peopleOrderByName =
                 from person in allPeople
                 orderby person.FirstName, person.LastName
                 select new {FullName = person.FirstName + " " + person.LastName };
            Console.WriteLine("\nPeople ordered by name:");
            foreach (var person in peopleOrderByName)
            {
                Console.WriteLine(person.FullName);
            }
        }
        public static void ToString(IEnumerable<Human> allPeople)
        {
            foreach (var person in allPeople)
            {
                Console.WriteLine(person);
            }
        }
        
    }
}
