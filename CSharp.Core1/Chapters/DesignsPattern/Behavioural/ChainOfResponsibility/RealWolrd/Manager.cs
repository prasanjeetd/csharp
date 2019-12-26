using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.ChainOfResponsibility.RealWolrd
{
    public class Manager : Approver
    {
        public override void ProcessLoan(Loan loan)
        {
            if (loan.Amount < 1000000)
            {
                Console.WriteLine("Approver: {0}", this.GetType().Name);
            }
            else if (nextApprover != null)
            {
                nextApprover.ProcessLoan(loan);
            }
        }
    }
}
