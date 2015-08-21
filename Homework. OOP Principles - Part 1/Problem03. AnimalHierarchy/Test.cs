using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.AnimalHierarchy
{
    class Test
    {
        static void Main(string[] args)
        {
            Animals[] listAnimals =
            {
                new Dog(3, "Arthur", Gender.male),
                new Dog(1, "Sunny", Gender.female),
                new Dog(7, "Fluffy", Gender.female),
                new Dog(9, "Stony", Gender.male),

                new Frog(1, "Froggy", Gender.male),
                new Frog(2, "LadyF", Gender.female),
                new Frog(1, "Frogo", Gender.male),
                new Frog(3, "Fifi", Gender.female),
                
                new Cat(3, "Sanya", Gender.female), 
                new Cat(1, "Suzzy", Gender.female), 
                new Cat(5, "Bobby", Gender.male), 
                new Cat(3, "Silver", Gender.male), 
                new TomCat(2, "Tom"),
                new TomCat(1, "Jerry"),
                new TomCat(6, "Paul"),
                new TomCat(2, "John"),
                new Kitty(1, "Kitty"),
                new Kitty(2, "Kate"),
                new Kitty(2, "Kathrine"),
                new Kitty(2, "Koki")
            };
            ListAnimals(listAnimals);
            Console.WriteLine("\n***Average Ages***\n");
            AverageAgeAnimals(listAnimals);
        }
        public static void AverageAgeAnimals(Animals[] listAnimals)
        {
            double averageAgeDogs = listAnimals.Where(x => x is Dog).Average(x => x.Age);
            Console.Write("The average age for the dogs is: ");
            Console.WriteLine("{0:F2} years.", averageAgeDogs);

            double averageAgeCats = listAnimals.Where(x => x is Cat).Average(x => x.Age);
            Console.Write("\nThe average age for the cats is: ");
            Console.WriteLine("{0:F2} years.", averageAgeCats);

            double averageAgeFrogs = listAnimals.Where(x => x is Frog).Average(x => x.Age);
            Console.Write("\nThe average age for the frogs is: ");
            Console.WriteLine("{0:F2} years.", averageAgeFrogs);
        }
        public static void ListAnimals(Animals[] listAnimals)
        {
            var listDogs =
                from animal in listAnimals
                where animal is Dog
                select animal;
            Console.WriteLine("The list with all dogs: ");
            ToString(listDogs);

            var listFrogs =
                from animal in listAnimals
                where animal is Frog
                select animal;
            Console.WriteLine("The list with all frogs: ");
            ToString(listFrogs);

            var listCats =
                from animal in listAnimals
                where animal is Cat
                select animal;
            Console.WriteLine("The list with all cats: ");
            ToString(listCats);
        }
        public static void ToString(IEnumerable<Animals> allAnimals)
        {
            foreach (var animal in allAnimals)
            {
                Console.Write("* {0}", animal);
                Console.WriteLine(animal.MakeSound());
            }
        }
    }
}
