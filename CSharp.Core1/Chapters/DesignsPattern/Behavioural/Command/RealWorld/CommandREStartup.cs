using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.Command.RealWorld
{
    public  static class CommandREStartup
    {
        public static void Call()
        {
            User user = new User();
            user.Compute("+", 50);
            user.Compute("*", 100);
            user.Compute("-", 20);
            user.Compute("+", 50);
            user.Compute("/", 10);

            user.Undo();
            user.Undo();
            user.Redo();
            user.Redo();
            user.Redo();
        }
        
    }
}
