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
  
        
        //protected double totalWithdrawal;
        //protected double numberWithdrawal;
        //protected double interestRate;
        //protected double serviceCharge;
        //protected AccountStatus accountStatus;
        public double StartingBalance { get; set; }
        public double CurrentBalance { get; set; }
        public double TotalDeposits { get; set; }
        public double NumberDeposits { get; set; }
        public double TotalWithdrawal { get; set; }
        public double NumberWithdrawal { get; set; }
        public double InterestRate { get; set; }
        public double ServiceCharge{ get; set; }
        
        public AccountStatus AccountStatus;
        public Account(double balance, double interestRate)
            {
                this.CurrentBalance = balance;
                this.StartingBalance = balance;
                this.InterestRate = interestRate;
            }

           

            public void CalculateInterest()
            {
                double monthlyInterestRate = InterestRate / 12;
                double monthlyInterest = monthlyInterestRate * CurrentBalance;
                CurrentBalance += monthlyInterest;
                Console.WriteLine("Monthly Interest Rate: "+monthlyInterestRate);
                Console.WriteLine("Monthly Interest: " + monthlyInterest);
            }
            

            public void MakeDeposit(double amount)
            {
                CurrentBalance += amount;
                NumberDeposits++;
            }

            public void MakeWithdrawal(double amount)
            {
                CurrentBalance -= amount;
                NumberWithdrawal++;
            }
            public string CloseAndReport()
            {
                
                StringBuilder builder = new StringBuilder();
                CurrentBalance -= ServiceCharge;
                CalculateInterest();

                double PercentageChange;
                NumberWithdrawal = 0;
                NumberDeposits = 0;
                ServiceCharge = 0;
                builder.Append(String.Format("Previous balance: {0:C2}\n",StartingBalance));
                builder.Append(String.Format("Current balance: {0:C2}\n",CurrentBalance));

                PercentageChange = (CurrentBalance - StartingBalance) / StartingBalance;
                builder.Append(String.Format("Percentage change: {0:P2}",PercentageChange));
                Console.WriteLine(builder.ToString());
                return builder.ToString();
            }
        
    }

}
