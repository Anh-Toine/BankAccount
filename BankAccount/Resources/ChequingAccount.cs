using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Resources
{
    class ChequingAccount:Account
    {
        public ChequingAccount(double balance,double interest) : base(balance,interest) { }

        public void MakeWithdrawal(double amount)
        {
            if(CurrentBalance < amount)
            {
                ServiceCharge -= 15;
            }
            else
            {
                base.MakeWithdrawal(amount);
            }
        }

        public void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }
        public void CloseAndReport()
        {
            ServiceCharge = 5 + (0.1 * TotalWithdrawal);
            base.CloseAndReport();
        }
    }
}
