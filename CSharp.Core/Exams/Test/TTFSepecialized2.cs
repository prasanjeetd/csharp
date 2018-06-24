using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.Test
{
    public class TTFSepecialized2 : TTFBase
    {
        public TTFSepecialized2(bool a, bool b, bool c)
                            : base(a, b, c)
        {
            if (a && !b && c)
                x = X.S;
            else if (a && b && !c)
                x = X.T;

        }

        public override decimal CalculateS(int d, int e, int f)
        {
            return f + d + (d * e / 100);
        }
    }
}
