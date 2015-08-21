using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07.Timer
{
    class TimerTest
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(Timer.Print, 2, 5000);
            timer.TimerExecute();
        }
    }
}
