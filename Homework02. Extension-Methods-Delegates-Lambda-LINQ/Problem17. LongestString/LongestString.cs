using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17.LongestString
{
    class LongestString
    {
        static void Main(string[] args)
        {
            string[] arrString = new string[] { "words", "wordswords", "ManyManyMAnyWrods" };
            var longestWord =
                from word in arrString
                orderby word.Length descending
                select word;

            Console.WriteLine("The longest word is:");
            Console.WriteLine(longestWord.ToArray()[0]);
        }
        
    }
}
