using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams
{
    public class Anagram
    {
        public static void Start()
        {

            string str1 = "billa";
            string str2 = "iblla";

            /*
            1. Char array
            2. Sort
            3.Join to string
            4. Compares
            */

            char[] ar1 = str1.ToCharArray();
            char[] ar2 = str2.ToCharArray();

            Array.Sort(ar1);
            Array.Sort(ar2);

            string sortedSt1 = new string(ar1);
            string sortedSt2 = new string(ar2);

            bool isAnagram = string.Equals(sortedSt1, sortedSt2);


        }
    }
}
