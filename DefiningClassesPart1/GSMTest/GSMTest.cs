using System;

namespace GSMTest
{
    class GSMTest
    {
        static void Test()
        {
            GSM firstPhone = new GSM("Galaxy Core Dou", "Samsung", 250, " ", "HugeBat", 200, 20, 5, 16000000);
            GSM secondPhone = new GSM("Galaxy Core Dou", "Samsung", 250);
            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine(firstPhone);
            Console.WriteLine(secondPhone);
        }
    }
}
