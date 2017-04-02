using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Core.Chapters.DesignsPattern.Behavioural.ChainOfResponsibility.RealWolrd
{
    public static class COR_RW
    {
        public static void Call()
        {
            Approver assistantManager = new AssistanManager();
            Approver manager = new Manager();
            Approver director = new Director();

            assistantManager.SetNextApprover(manager);
            manager.SetNextApprover(director);

            Loan homeLoan = new Loan { LoanNo = 12222, Amount = 3500000, Purpose = "Home Loan" };
            Loan carLoan = new Loan { LoanNo = 999, Amount = 900000, Purpose = "Car Loan" };
            Loan personalLoan = new Loan { LoanNo = 999, Amount = 400000, Purpose = "Personal Loan" };

            assistantManager.ProcessLoan(homeLoan);
            assistantManager.ProcessLoan(carLoan);
            manager.ProcessLoan(homeLoan);
            manager.ProcessLoan(carLoan);

        }
    }
}
