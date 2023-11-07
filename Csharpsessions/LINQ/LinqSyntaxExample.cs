using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpsessions.LINQ
{
    /// <summary>
    /// Contains two methods that compile to the same C# code. They are both
    /// LINQ queries, one written in query syntax and the other written in 
    /// Method syntax.
    /// </summary>
    public class LinqSyntaxExample
    {
        int[] numbers = { 1, 2, 3 };

        int[] QuerySyntax()
        {
            var query =
                from num in numbers
                where num % 3 == 0
                select num;
            return query.ToArray();
        }

        int[] MethodSyntax()
        {
            var query = numbers.Where(num => num % 3 == 0).Select(num => num);
            return query.ToArray();
        }
    }

}
