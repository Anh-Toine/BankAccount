using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Exceptions
{
    class IllegalMainMenuOptionException : ApplicationException
    {
        private string ErrorMessage = string.Empty;
        public IllegalMainMenuOptionException() { }
        public IllegalMainMenuOptionException(string ErrorMessage)
        {
            this.ErrorMessage = ErrorMessage;
        }
        public override string Message
        {
            get
            {
                return "An error has occurred: " + ErrorMessage;
            }
        }
    }
}
