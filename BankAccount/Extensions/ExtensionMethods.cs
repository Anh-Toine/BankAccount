using BankAccount.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Extensions
{
    public static class ExtensionMethods
    {
        public static string GetPercentageChange(this Account account)
        {

            return String.Format("{0:P2}",(account.CurrentBalance - account.StartingBalance)/account.StartingBalance * 100);
        }
        public static string ToNAMoneyFormat(this bool format, Account acc)
        {
            string moneyformat;
            Double number = acc.CurrentBalance;
            if (format)
            {
                moneyformat = String.Format("{0:C2}",Math.Ceiling(number));
                return moneyformat;
            }
            else
            {
                moneyformat = String.Format("{0:C2}", Math.Floor(number));
                return moneyformat;
            }
            
        }

    }
}
