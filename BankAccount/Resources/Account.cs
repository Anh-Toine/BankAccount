using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Resources
{
    public enum AccountStatus
    {
        Active,
        Inactive
    }
    public abstract class Account : IAccount
        {
            private double startingBalance;
            private double currentBalance;   
            private double totalDeposits;
            private double numberDeposits;
            private double totalWithdrawal;
            private double numberWithdrawl;
            private double interestRate;
            private double serviceChange;
            private AccountStatus accountStatus;

            public Account(double currentBalance, double startingBalance, double interestRate)
            {
                this.currentBalance = currentBalance;
                this.startingBalance = startingBalance;
                this.interestRate = interestRate;
            }

            public double StartingBalance
            {
                get { return startingBalance; }
                set { startingBalance = value; }
            }
            public double CurrentBalance
            {
                get { return currentBalance; }
                set { currentBalance = value; }
            }    
            public double MakeDeposit(double amount)
            {
                currentBalance += amount;
                return currentBalance;
            }
            public double MakeWithdrawal(double amount)
            {
                currentBalance -= amount;
                return currentBalance;
            }
            
    }

}
