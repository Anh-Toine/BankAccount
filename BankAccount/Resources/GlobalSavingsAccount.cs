using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Resources
{
    class GlobalSavingsAccount : SavingsAccount,IExchangeable
    {
        public GlobalSavingsAccount(double balance,double interestrate) : base(balance, interestrate) { }
        public double USValue(double r)
        {
            return CurrentBalance * r;
        }
    }
}
