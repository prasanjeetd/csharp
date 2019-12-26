using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Command.RealWorld
{
    public class CalculatorCommand : Command
    {
        private Calculator _calculator;

        public string Operator { get; set; }

        public int Operand { get; set; }

        public CalculatorCommand(Calculator calculator, String @operator, int operand)
        {
            this._calculator = calculator;
            this.Operator = @operator;
            this.Operand = operand;
        }

        public override void Execute()
        {
            this._calculator.Operation(this.Operator, this.Operand);
        }

        public override void Unexecute()
        {
            this._calculator.Operation(Undo(this.Operator), this.Operand);
        }

        private string Undo(string @operator)
        {
            switch (@operator)
            {
                case "+":
                    return "-";
                case "-":
                    return "+";
                case "*":
                    return "/";
                case "/":
                    return "*";
                default:
                    throw new ArgumentException();
            }
        }
    }
}
