using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Command.RealWorld
{
    public class User
    {
        private Calculator calculator = new Calculator();
        List<Command> commands = new List<Command>();
        private int _cnt = 0;

        public void Compute(string @operator , int operand)
        {
            var command = new CalculatorCommand(calculator, @operator, operand);
            command.Execute();
            commands.Add(command);
            _cnt++;
        }

        public void Undo()
        {
            if (_cnt > 0)
            {
                var command = commands[_cnt - 1];
                command.Unexecute();
                _cnt--;
            }
        }

        public void Redo()
        {
            if (_cnt < commands.Count)
            {
                var command = commands[_cnt];
                command.Execute();
                _cnt++;
            }
        }
    }
}
