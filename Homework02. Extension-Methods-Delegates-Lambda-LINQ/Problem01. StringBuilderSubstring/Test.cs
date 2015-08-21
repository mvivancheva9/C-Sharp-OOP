using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01.StringBuilderSubstring
{
    class Test
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            text.Append("Some important text");
            StringBuilder substringResult = text.Substring(15, 4);

            Console.WriteLine(substringResult);
        }
    }
}
