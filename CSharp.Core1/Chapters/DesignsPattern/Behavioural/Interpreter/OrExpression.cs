using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Interpreter
{
    public class OrExpression : IExpression
    {
        IExpression _exp1;
        IExpression _exp2;

        public OrExpression(IExpression exp1, IExpression exp2)
        {
            _exp1 = exp1;
            _exp2 = exp2;
        }

        public bool Interpret(string context)
        {
            return _exp1.Interpret(context) || _exp2.Interpret(context);
        }
    }
}
