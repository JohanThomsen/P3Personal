using System;
using System.Collections.Generic;
using System.Text;

namespace FklubStregSystemEksamen.Data
{
    public class IDProvider
    {
        int internalID = 0;

        public int Next()
        {
            return internalID++;
        }
    }
}
