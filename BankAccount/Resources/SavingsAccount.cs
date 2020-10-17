using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Resources
{
    class SavingsAccount : Account
    {
        protected AccountStatus account;

        public SavingsAccount(double balance, double interest) : base(balance, interest) { }

        public void MakeWithdrawal(double amount)
        {
            if(account == AccountStatus.Inactive)
            {
                base.MakeWithdrawal(amount);
            }
        }
        public void MakeDeposit(double amount)
        {

            base.MakeDeposit(amount);
            if (account == AccountStatus.Inactive && base.CurrentBalance > 25)
            {
                account = AccountStatus.Active;

            }

        }
    }
}
