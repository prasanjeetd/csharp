using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.ChainOfResponsibility
{
    public static class CORStartup
    {
        public static void Call()
        {
            Handler handler1 = new Handler1();
            Handler handler2 = new Handler2();
            Handler handler3 = new Handler3();

            handler1.SetSuccesor(handler2);
            handler2.SetSuccesor(handler3);

            handler1.Handle(30);
            handler2.Handle(15);
            handler3.Handle(35);

        }
    }
}
