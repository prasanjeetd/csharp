using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler succesor;

        public void SetSuccesor(Handler succesor)
        {
            this.succesor = succesor;
        }

        public abstract void Handle(int request);
    }

    public class Handler1: Handler
    {
        public override void Handle(int request)
        {
            if(request >0  && request < 11)
            {
                Console.WriteLine("Class: " + this.GetType().Name);
            }
            else if( succesor !=null)
            {
                succesor.Handle(request);
            }
        }
    }

    public class Handler2 : Handler
    {
        public override void Handle(int request)
        {
            if( request > 10 && request <21)
            {
                Console.WriteLine("Class:" + this.GetType().Name);
            }
            else if( succesor != null)
            {
                succesor.Handle(request);
            }
        }
    }

    public class Handler3 : Handler
    {
        public override void Handle(int request)
        {
            if (request > 20 )
            {
                Console.WriteLine("Class:" + this.GetType().Name);
            }
            else if (succesor != null)
            {
                succesor.Handle(request);
            }
        }
    }
}
