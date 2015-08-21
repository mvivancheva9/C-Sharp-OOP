using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.AnimalHierarchy
{
    class Frog : Animals, ISound
    {
        //constructors
        public Frog(int age, string name, Gender sex)
            : base(age, name, sex)
        {

        }

        //methods

        public override string MakeSound()
        {
            return string.Format("and says Kvak-kvak.");
        }
    }
}
