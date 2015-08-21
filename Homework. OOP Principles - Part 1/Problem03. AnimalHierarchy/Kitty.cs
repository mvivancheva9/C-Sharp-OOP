using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.AnimalHierarchy
{
    class Kitty : Cat
    {
        public Kitty(int age, string name)
            : base(age, name)
        {
            this.Sex = Gender.female;
        }
    }
}
