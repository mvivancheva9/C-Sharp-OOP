using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06.DivisibleBy3and7
{
    class DivisionTest
    {
        static void Main(string[] args)
        {
            int[] arrInt = new int[] { 1, 2, 3, 21, 42, 55, 66, 7 };
            NumbersDivisible(arrInt);
        }
        public static void NumbersDivisible(IEnumerable<int> arrInt)
        {
            //LINQ
            var nimbersDivisibleLINQ =
                 from number in arrInt
                 where number % 3 == 0 && number % 7 == 0
                 select number;
            Console.WriteLine("Numbers divisible by both 3 and 7, using LINQ:");
            ToString(nimbersDivisibleLINQ);

            //Lambda
            var nimbersDivisibleLambda =
                arrInt.Where(number => number % 3 == 0 && number % 7 == 0).
                Select(number => number);
            Console.WriteLine("\nNumbers divisible by both 3 and 7, using Lambda Expressions:");
            ToString(nimbersDivisibleLambda);

        }
        public static void ToString(IEnumerable<int> arrInt)
        {
            foreach (var number in arrInt)
            {
                Console.WriteLine(number);
            }
        }
    }
}
