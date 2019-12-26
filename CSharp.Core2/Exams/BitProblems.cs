using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Exams
{
    public class BitProblems
    {
        public void ConvertToBit()
        {
            int intValue = 146;

            BitArray bitArrays = new BitArray(new int[] { intValue });

            bool[] bits = new bool[bitArrays.Count];
            bitArrays.CopyTo(bits, 0);

            byte[] bitValues = bits.Select(x => (byte)(x ? 1 : 0)).ToArray();

            string bytes = string.Join("",bitValues);
        }

        public void ConvertToBytes()
        {
            int x = 3;
            string s = Convert.ToString(x,2); //Convert to binary in a string

            string fullString = s.PadLeft(8, '0');


            int[] bits = Array.ConvertAll(fullString.ToCharArray(), e => int.Parse(e.ToString()));

            //int[] bits = fullString// Add 0's from left
            //             .Select(c => int.Parse(c.ToString())) // convert each char to int
            //             .ToArray(); // Convert IEnumerable from select to Array

            string bytes = String.Join("", bits);
        }


        public void CalculateXOR()
        {
            int a = 146;
            int b = 137;

            int[] aValue = GetBits(a);
            int[] bValue = GetBits(b);

            int xor = a ^ b;
            int[] xorValue = GetBits(xor);

            int bitNeedsToSwap = xorValue.Count(x => x == 1);

        }

        public int[] GetBits(int value) {

            string bits = Convert.ToString(value, 2).PadLeft(8, '0');

            int[] bitArrays = bits.Select(x => int.Parse(x.ToString())).ToArray();

            return bitArrays;

        }

    }
}
