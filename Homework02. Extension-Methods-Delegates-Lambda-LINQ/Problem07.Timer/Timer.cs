using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Problem07.Timer
{
    // Declare delegate
    public delegate void TimerDelegate();
    class Timer
    {
        // Fields
        private int timesOfExecute;
        private int intervalOfMilliseconds;
        private TimerDelegate timerDelegate;

        // Constructor
        public Timer(TimerDelegate timerDelegate, int timesOfExecute, int intervalOfMilliseconds)
        {
            this.timerDelegate = timerDelegate;
            this.timesOfExecute = timesOfExecute;
            this.intervalOfMilliseconds = intervalOfMilliseconds;
        }

        // Encapsulation
        public int TimesOfExecute
        {
            get { return this.timesOfExecute; }
            set { this.timesOfExecute = value; }
        }

        public int IntervalOfMilliseconds
        {
            get { return this.intervalOfMilliseconds; }
            set { this.intervalOfMilliseconds = value; }
        }

        public TimerDelegate TimerDelegate
        {
            get { return this.timerDelegate; }
            set { this.timerDelegate = value; }
        }

        // Methods
        // Start timer
        public void TimerExecute()
        {
            for (int i = 0; i < TimesOfExecute; i++)
            {
                Thread.Sleep(IntervalOfMilliseconds);
                TimerDelegate();
            }
        }

        // Print something
        public static void Print()
        {
            Console.WriteLine("Some text to be tested");
        }
    }
}
