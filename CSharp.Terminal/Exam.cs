using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Terminal
{
    class Exam
    {
        static int getRange(int[] scores, int lower, int upper)
        {

            int count = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                int value = scores[i];

                if (value >= lower && value <= upper)
                {
                    count++;
                }
            }

            return count;
        }

        static int[] jobOffers(int[] scores, int[] lowerLimits, int[] upperLimits)
        {
            int[] results = new int[lowerLimits.Length];

            for (int i = 0; i < lowerLimits.Length; i++)
            {
                int count = getRange(scores, lowerLimits[i], upperLimits[i]);
                results[i] = count;
            }

            return results;
        }
    }
}
