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
            string input2 = "hands jumbled terrific old-fashioned grass highfalutin stupendous daughter feigned skirt modern truthful";
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
            /* ÖVNING 3
            string pattern = "a.";
            var matches = Regex.Matches(input, pattern);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            } */

            /* ÖVNING 4
            string pattern = "[^t]t[^t]";
            var matches = Regex.Matches(input, pattern);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            } */

            // ÖVNING 5
            /*
            string pattern = "(as)|(od)";
            var matches = Regex.Matches(input2, pattern);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            } */

            /* ÖVNING 6
            string pattern = "([ae][nds])";
            var matches = Regex.Matches(input2, pattern);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            } */

            /* ÖVNING 7
            string pattern1 = @"\b([hd]\w*)\b";
            string pattern2 = @"\w+s\b";
            var matches1 = Regex.Matches(input2, pattern1);
            var matches2 = Regex.Matches(input2, pattern2);
            foreach (var match in matches1)
            {
                Console.WriteLine(match);
            }
            foreach (var match in matches2)
            {
                Console.WriteLine(match);
            } */

            var matches = Regex.Matches(input2, @"\b\w[aouåeiyäö]\w+\b");
            Console.WriteLine(matches.Count);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
            Console.ReadKey();
        }
    }
}
