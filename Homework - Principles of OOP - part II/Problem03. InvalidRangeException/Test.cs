using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.InvalidRangeException
{
    class Test
    {
        static void Main()
        {
            const int Start = 0;
            const int End = 100;
            DateTime LowerDate = new DateTime(1980, 1, 1);
            DateTime UpperDate = new DateTime(2013, 12, 31);
            try
            {
                int wrongNumber = 150;
                if (wrongNumber < Start || wrongNumber > End)
                {
                    throw new InvalidRangecs<int>("Number out of range!", Start, End);
                }
            }
            catch (InvalidRangecs<int> ex)
            {
                Console.WriteLine("Wrong number entered. Number must be in range {0} - {1}", ex.Start, ex.End);
            }
            try
            {
                DateTime wrongDate = new DateTime(2015, 10, 15);
                if (wrongDate < LowerDate || wrongDate > UpperDate)
                {
                    throw new InvalidRangecs<DateTime>("Date out of range!", LowerDate, UpperDate);
                }
            }

            catch (InvalidRangecs<DateTime> ex)
            {
                Console.WriteLine("Wrong date entered. Date must be in range {0:dd/MM/yyyy} - {1:dd/MM/yyyy}", ex.Start, ex.End);
            }
        }
    }
}
