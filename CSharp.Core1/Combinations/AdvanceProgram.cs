using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Combinations
{
    public class AdvanceProgram
    {
        public void Calculate()
        {

            int[] billa = new int[] { 1, 2, 3, 4,5 };

            for (int i = 0; i < billa.Length-1; i++)
            {
               
                var aStartIndex = i;
                int aEndIndex = billa.Length -2;

                Console.WriteLine("################################");
                while (aEndIndex > 0 && aStartIndex < aEndIndex)
                {
                    for (int j = aStartIndex; j < aEndIndex; j++)
                    {
                        Console.Write(billa[j] + "\t");
                    }

                    Console.Write("::");
                    for (int k = aEndIndex; k < billa.Length; k++)
                    {
                        Console.Write(billa[k] + "\t");
                    }

                    Console.WriteLine();
                    aEndIndex--;
                }

                 aStartIndex = i+1;
                 aEndIndex = billa.Length-1 ;

                Console.WriteLine("***************************");
                while (aStartIndex< billa.Length && aStartIndex < aEndIndex)
                {
                    Console.Write(billa[i] + "\t");
                    for (int j = aStartIndex; j < aEndIndex; j++)
                    {
                        Console.Write(billa[j] + "\t");
                    }

                    Console.Write("::");
                    for (int k = aEndIndex; k < billa.Length; k++)
                    {
                        Console.Write(billa[k] + "\t");
                    }

                    Console.WriteLine();
                    aStartIndex++;
                }
            }

        }
    }
}
