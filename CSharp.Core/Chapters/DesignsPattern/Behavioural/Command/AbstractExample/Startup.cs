using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Command.AbstractExample
{
    public static class CommandStartup
    {
        public static void Call()
        {
            Reciever receiver = new Reciever();
            Command command = new Command1(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

        }

    }
}
