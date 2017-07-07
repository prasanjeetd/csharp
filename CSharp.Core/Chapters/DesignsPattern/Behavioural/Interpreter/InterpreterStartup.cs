using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Interpreter
{
    public static class InterpreterStartup
    {
        public static void Call()
        {
            Client client = new Client();

            IExpression maleExpression = client.GetMaleExpression();
            IExpression marriedWomanExpression = client.GetMarriedWomanExpression();

            Console.WriteLine("Is male: {0}", maleExpression.Interpret("Billa"));
            Console.WriteLine("Is married woman :  {0}", marriedWomanExpression.Interpret("Married julie"));

        }
    }
}
