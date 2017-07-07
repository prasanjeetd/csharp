using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams.YNAB
{
    public class YNAB
    {
        public void Start()
        {
            Console.WriteLine("YNAB Program started");

            var array = new int[] { 4,2,1,2,3,5,2,1,3 };
            Simplify(array);
        }

        public int [] Simplify(int [] array)
        {

            Dictionary<int, int> uniqueItems = new Dictionary<int, int>();

            foreach( var item in array)
            {
                if (!uniqueItems.ContainsKey(item))
                {

                    uniqueItems.Add(item, 1);
                }
                else
                    uniqueItems[item]++;
            }

            var uniqueKeys = uniqueItems.Keys.ToList();
            uniqueKeys.Sort();
            return uniqueKeys.ToArray();

        }
    }
}
