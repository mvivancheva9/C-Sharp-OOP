using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.AnimalHierarchy
{
    class Cat : Animals, ISound
    {
        //constructors
        public Cat(int age, string name, Gender sex)
            : base(age, name, sex)
        {

        }
        public Cat(int age, string name)
            : base(age, name)
        {

        }
        //methods

        public override string MakeSound()
        {
            return string.Format("and says Miau-miau.");
        }
    }
}
