using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Opgaver
{
    [Serializable]
    public class IllegalGearChangeException : Exception
    {
        public IllegalGearChangeException()
        { }

        public IllegalGearChangeException(string message)
            : base(message)
        { }

        public IllegalGearChangeException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
