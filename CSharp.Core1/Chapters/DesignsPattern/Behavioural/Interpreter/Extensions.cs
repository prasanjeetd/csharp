using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Interpreter
{
    public static class Extensions
    {
        public static bool DoesContains(this string text,
            string value,
            StringComparison ignoreCase = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, ignoreCase) >=0;
        }
    }
}
