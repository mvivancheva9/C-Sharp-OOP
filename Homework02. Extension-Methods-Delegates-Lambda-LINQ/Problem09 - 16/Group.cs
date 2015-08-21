using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09___16
{
    public class Group
    {
        private int groupNumber;
        private string departmentName;

        //constructor
        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
        //encapsulation
        public int GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Please fill an group number");
                }
                this.groupNumber = value;
            }
        }
        public string DepartmentName
        {
            get { return this.departmentName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please fill a department name");
                }
                this.departmentName = value;
            }
        }

        public override string ToString()
        {
            return this.GroupNumber + ":" + this.DepartmentName;
        }
    }
}
