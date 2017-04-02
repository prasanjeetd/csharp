using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.ChainOfResponsibility.RealWolrd
{
    public abstract class Approver
    {
        protected Approver nextApprover;

        public void SetNextApprover(Approver nextApprover)
        {
            this.nextApprover = nextApprover;
        }

        public abstract void ProcessLoan(Loan loan);
    }
}
