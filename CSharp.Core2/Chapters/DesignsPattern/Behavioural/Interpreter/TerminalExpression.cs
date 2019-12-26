using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Interpreter
{
    public class TerminalExpression : IExpression
    {
        private string _data;

        public TerminalExpression(string data)
        {
            this._data = data;
        }

        public bool Interpret(string context)
        {
            return context.DoesContains(_data);
        }
    }
}
