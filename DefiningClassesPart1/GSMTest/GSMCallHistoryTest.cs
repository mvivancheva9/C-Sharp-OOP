using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMTest
{
    class GSMCallHistoryTest
    {
        static GSM myPhone = GSM.IPhone4S;
        public static void Main()
        {
            myPhone.AddCall("11/03/2015", "15:15", "0896000000", 180);
            myPhone.AddCall("11/03/2015", "15:25", "+359896555555", 60);
            myPhone.AddCall("11/03/2015", "15:35", "+359896777777", 300);
            myPhone.AddCall("11/03/2015", "15:45", "+359888888888", 256);

            Console.WriteLine("Calls Information before:");

            foreach (var call in myPhone.CallHistory)
            {
                Console.WriteLine("Date: {0}, \nTime: {1}, \nDialed Phone: {2}, \nDuration: {3} seconds\n", call.Date, call.Time, call.PhoneNum, call.Duration);
            }
            Console.WriteLine("Total price for all calls: {0}", myPhone.CalculateTotalPrice(0.37));
            Console.WriteLine();
            Console.WriteLine("Calls Information after:");
            List<Call> calls = myPhone.CallHistory;
            Call maxDurationCall = calls.Max();
            calls.Remove(maxDurationCall);

            foreach (var call in myPhone.CallHistory)
            {
                Console.WriteLine("Date: {0}, \nTime: {1}, \nDialed Phone: {2}, \nDuration: {3} seconds\n", call.Date, call.Time, call.PhoneNum, call.Duration);
            }
            Console.WriteLine("Total price for all calls: {0}", myPhone.CalculateTotalPrice(0.37));

            myPhone.ClearCallHistory();
        }
    }
}
