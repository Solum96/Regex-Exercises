using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "min katt har tre konkatenerade kanter";
            /* ÖVNING 1

            string pattern = "kat";
            Match match = Regex.Match(input, pattern);
            Console.WriteLine(match.Success); */

            /* ÖVNING 2
            string pattern = "(kat)|(kan)|(kon)";
            var matches = Regex.Matches(input, pattern);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            } */

            string pattern = "a.";
            var matches = Regex.Matches(input, pattern);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
            Console.ReadKey();
        }
    }
}
