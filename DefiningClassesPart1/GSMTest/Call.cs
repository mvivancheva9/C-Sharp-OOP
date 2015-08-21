using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMTest
{
    class Call : IComparable
    {
        private string date;
        private string time;
        private string phoneNum;
        private int duration;

        //constructors
        public Call(string date, string time, string dialedNum, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.PhoneNum = dialedNum;
            this.Duration = duration;
        }

        //encapsulation
        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public string PhoneNum
        {
            get { return this.phoneNum; }
            set { this.phoneNum = value; }
        }
        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        //methods
        public int CompareTo(object obj)
        {
            Call toBeComapredTo = obj as Call;
            if (this.Duration > toBeComapredTo.Duration)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

    }
}
