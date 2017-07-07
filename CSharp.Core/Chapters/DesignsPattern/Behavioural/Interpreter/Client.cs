using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Interpreter
{
    public class Client
    {
        public IExpression GetMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");

            return new OrExpression(robert, john);
        }

        public IExpression GetMarriedWomanExpression()
        {
            IExpression married = new TerminalExpression("Married");
            IExpression julie = new TerminalExpression("Julie");

            return new AndExpression(married, julie);
        }

    }
}
