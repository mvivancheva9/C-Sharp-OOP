using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.StudentsAndWorkers
{
    class Worker : Human
    {
        //fields
        private double weekSalary;
        private int workHoursPerDay;
        
        //constructors
        public Worker (string firstName, string lastName, double weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        //encapsulation
        public double WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }
        //methods
        public double MoneyPerHour()
        {
            double moneyPerHour = this.WeekSalary / (this.WorkHoursPerDay * 5);
            return moneyPerHour;
        }
        public override string ToString()
        {
            double moneyPerHour = MoneyPerHour();
            return string.Format("Money earned per hour:[{0:F2}] {1} {2}", moneyPerHour, this.FirstName, this.LastName);
        }
    }
}
