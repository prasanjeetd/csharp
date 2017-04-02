using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Command.RealWorld
{
    public class Calculator
    {
        private int _value = 0;

        public void Operation(string  @operator, int operand)
        {
            switch (@operator)
            {
                case "+":
                    _value += operand;
                    break;
                case "-":
                    _value -= operand;
                    break;
                case "*":
                    _value *= operand;
                    break;
                case "/":
                    _value /= operand;
                    break;
            }

            Console.WriteLine("Current value ={0,3} (following {1} {2})", _value, @operator, operand);
        }

        
    }
}
