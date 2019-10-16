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
            string pattern = "kat";

            Match match = Regex.Match(input, pattern);
            Console.WriteLine(match.Success);
            Console.ReadKey();
        }
    }
}
