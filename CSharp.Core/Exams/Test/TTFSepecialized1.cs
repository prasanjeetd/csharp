using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.Test
{
    public class TTFSepecialized1 : TTFBase
    {
        public TTFSepecialized1(bool a, bool b, bool c)
                            : base(a, b, c)
        {
        }

        public override decimal CalculateR(int d, int e, int f)
        {
            return (decimal)2d + (d * f / 100);

        }
    }
}
