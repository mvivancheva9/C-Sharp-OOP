using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMTest
{
    class Battery
    {
        private string batteryModel;
        private int? hoursIdle;
        private int? hoursTalk;
        enum BatteryType { LiIon, NiMH, NiCD };
        private BatteryType batteryType;

        //constructors
        public Battery ()
        {
            this.BatteryModel = null;
            this.HoursIdle = null;
            this.HoursTalk = null;
            this.batteryType= BatteryType.LiIon;
        }
        public Battery(string batteryModel, int hoursIdle, int hoursTalk)
        {
            this.BatteryModel = batteryModel;
            this.HoursTalk = hoursTalk;
            this.HoursIdle = hoursIdle;
        }

        //encapsulation
        public string BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }
        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }
        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        //methods
        public override string ToString()
        {
            return string.Format("Hours Idle: {0}, Hours Talk: {1}, Battery Model: {2}", hoursIdle, hoursTalk, batteryModel);
        }
    }
}
