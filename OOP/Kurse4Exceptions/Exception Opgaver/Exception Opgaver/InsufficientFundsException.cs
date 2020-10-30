using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Opgaver
{
    [Serializable]
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException()
        { }

        public InsufficientFundsException(string message)
            : base(message)
        { }

        public InsufficientFundsException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
