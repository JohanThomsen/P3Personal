using System;
using System.Runtime.Serialization;

namespace FklubStregSystemEksamen.Exceptions
{
    [Serializable]
    internal class FailedTransactionException : Exception
    {
        public FailedTransactionException()
        {
        }

        public FailedTransactionException(string message) : base(message)
        {
        }

        public FailedTransactionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FailedTransactionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}