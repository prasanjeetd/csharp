using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams
{
    public class FindOneOccurance
    {
        public void Get()
        {

            int[] array = { 12, 1, 12, 3, 12, 1, 1, 2, 3, 2, 2, 3, 7 };

            int bitSum = 0;
            for(int i=0;i< array.Length;i++)
            {
                bitSum = bitSum & array[i];
            }


        }
    }
}
