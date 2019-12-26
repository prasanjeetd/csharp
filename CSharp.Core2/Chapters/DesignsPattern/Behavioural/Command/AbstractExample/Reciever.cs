using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Command.AbstractExample
{
    public class Reciever
    {
        public void Action()
        {
            Console.WriteLine("Class: {0}", this.GetType().Name);
        }
    }

    public abstract class Command
    {
        protected Reciever reciever;

        protected Command (Reciever reciever)
        {
            this.reciever = reciever;
        }

        public abstract void Execute();
    }

    public class Command1 : Command
    {
        public Command1(Reciever receiver):
            base(receiver)
        {

        }

        public override void Execute()
        {
            reciever.Action();
        }
    }

    public class Invoker
    {
        private Command _command;

        public void SetCommand (Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            this._command.Execute();
        }

    }
}
