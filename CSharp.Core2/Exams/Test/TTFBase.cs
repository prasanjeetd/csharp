using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.Test
{

    public class TTFBase : ITTF
    {
        public X x { get; set; }

        public decimal y { get; set; }

        public TTFBase(bool a, bool b, bool c)
        {
            if (a && b && !c)
            {
                x = X.S;
            }
            else if (a && b && c)
            {
                x = X.R;
            }
            else if (!a && b && c)
            {
                x = X.T;
            }

        }

        public decimal GetResult(int d, int e, int f)
        {

            if (x == X.S)
                y = CalculateS(d, e, f);
            else if (x == X.R)
                y = CalculateR(d, e, f);
            else if (x == X.T)
                y = CalculateT(d, e, f);

            return y;
        }

        public virtual decimal CalculateS(int d, int e, int f)
        {
            return d + (d * e / 100);
        }

        public virtual decimal CalculateR(int d, int e, int f)
        {
            return d + (d * (e - f) / 100);
        }

        public virtual decimal CalculateT(int d, int e, int f)
        {
            return d - (d * (d * f) / 100);
        }
    }


}
