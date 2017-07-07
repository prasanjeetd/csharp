using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams
{
    public class FirstElementProblem
    {
        public  static void GetAllNumbersWithOneOccurances()
        {
            int[] array = { 2, 3, 4, 5, 8, 2, 3, 5, 4, 2, 3, 4, 6 };

            var unique = (from g in array.GroupBy(x => x)
                         where g.Count() == 1
                         select g.Key).ToArray();

        }

        public static void GetFirstNumbersWithOneOccurances()
        {
            int[] array = { 2, 3, 4, 5, 8, 2, 3, 5, 4, 2, 3, 4, 6 };

            var unique = (from g in array
                          group array by g into grp
                          where grp.Count() == 1
                          select grp.First());

        }
    }
}
