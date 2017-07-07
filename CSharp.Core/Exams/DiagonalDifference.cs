using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams
{
    public class DiagonalDifference
    {
        public void Difference()
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 3;
            int[][] a = new int[][] {
                new[] { 11, 2, 4 } ,
                new[] { 4, 5, 6 },
                new[] { 10, 8, -12 }
            };

            //for (int a_i = 0; a_i < n; a_i++)
            //{
            //    string[] a_temp = Console.ReadLine().Split(' ');
            //    a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            //}

            int sum1 = 0;
            int sum2 = 0;
            
            for (int i =0;i< n;i++)
            {
                sum1 = sum1+ a[i][i];
                sum2 = sum2+a[i][n-i-1];
            }

            int result = Math.Abs(sum1 - sum2);
            Console.WriteLine(result);

        }

        public void Fraction()
        {

            int[] array = { -4 ,3, - 9, 0, 4, 1 };

            int positiveCount = array.Count(x => x > 0);
            int negativeCount = array.Count(x => x < 0);
            int zeroCount = array.Count(x => x == 0);

            double positiveFraction = (double)positiveCount / array.Length;
            double negativeFraction = (double)negativeCount / array.Length;
            double zeroFraction = (double)zeroCount/ array.Length;

            Console.WriteLine(positiveFraction);
            Console.WriteLine(negativeFraction);
            Console.WriteLine(zeroFraction);
        }
    }
}
