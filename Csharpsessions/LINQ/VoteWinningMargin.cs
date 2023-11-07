using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpsessions.LINQ
{
    internal class VoteWinningMargin
    {
        private const string votes = "Yes,Yes,No,Yes,No,Yes,No,No,No,Yes,Yes,Yes,Yes,No,Yes,No,No,Yes,Yes";

        internal static void Run()
        {
            var votesList = votes.Split(",").ToList<string>();

            // boring way
            int numberOfYes = votesList.Count(element => element == "Yes");
            int numberOfNo = votesList.Count(element => element == "No");
            int difference = numberOfYes - numberOfNo;

            Console.WriteLine(difference);


            // cool way
            int difference2 = votesList.Aggregate(0, (total, element) => (total + (element == "Yes" ? +1 : -1)));
            
            Console.WriteLine(difference2);
        }
    }
}
