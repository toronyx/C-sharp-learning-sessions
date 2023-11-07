using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpsessions.LINQ
{
    internal static class StringParsingExercise
    {
        internal static string inputString = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";

        internal static IEnumerable<(string name, string dateOfBirth)> ParseString()
        {
            return inputString.Split(";").Select(str => str.Trim().Split(", ")).Select(strArray => (strArray[0], strArray[1]));
        }

        internal static IEnumerable<(string name, string dateOfBirth)> StringOrderedByYears()
        {
            return ParseString().OrderBy(strTuple => int.Parse(strTuple.dateOfBirth.Split("/").Last()));
        }

        internal static void Run()
        {
            StringOrderedByYears().ToList().ForEach(x => Console.WriteLine($"{x.name}, {x.dateOfBirth}"));
        }
    }
}