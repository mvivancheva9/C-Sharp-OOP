using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.Student_class
{
    class Test
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Dravan", "Draganov", "Draganov", "1568965417","Sofia", "0888888888", "ddd@gmail.com", "mathematics", Specialties.Economics, Universities.TuSofia, Faculties.Economics);
            var student2 = new Student("Dravan", "Draganov", "Draganov", "1568965417","Sofia", "0888888888", "ddd@gmail.com", "mathematics", Specialties.Economics, Universities.TuSofia, Faculties.Economics);
            var student3 = new Student("Dravana", "Draganova", "Draganova", "56568965417", "Sofia", "0888888999", "ddda@gmail.com", "programming", Specialties.ComputerScience, Universities.AUBG, Faculties.ComputerScience);

            Console.Write("The specific HashCode of the student is: ");
            Console.WriteLine(student1.GetHashCode());
            Console.Write("\nCheck whether the two students are equal: ");
            Console.WriteLine(student1.Equals(student2));
            Console.Write("\nCheck whether the two students are equal: ");
            Console.WriteLine(student2 == student3);
            Console.Write("\nCheck whether the two students are not equal: ");
            Console.WriteLine(student1 != student3);

            var student4 = (Student)student3.Clone();
            Console.Write("\nCheck whether the two cloned students are equal: ");
            Console.WriteLine(student4 == student3);
            Console.Write("\nComparing two students:");
            Console.WriteLine(student2.CompareTo(student3));
        }
    }
}
