using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Exceptions
{
    class NumberValueException : ApplicationException
    {
        private string ErrorMessage = string.Empty;
        public NumberValueException() { }
        public NumberValueException(string ErrorMessage)
        {
            this.ErrorMessage = ErrorMessage;
        }
        public override string Message
        {
            get
            {
                return ErrorMessage;
            }
        }
    }
}
