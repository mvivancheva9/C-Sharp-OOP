using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version
{
    [Version("2.10")]
    class VersionTest
    {
        static void Main()
        {
            object[] attributes = typeof(VersionTest).GetCustomAttributes(false);
            Console.WriteLine("Version: {0}", attributes[0]);
        }
    }
}
