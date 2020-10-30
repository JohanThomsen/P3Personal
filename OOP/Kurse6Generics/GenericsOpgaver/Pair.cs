using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsOpgaver
{
    class Pair<T1, T2>
    {
        public T1 Value1 { get;}
        public T2 Value2 { get;}

        public Pair(T1 value1, T2 value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public Pair<T2, T1> Swap()
        {
            return new Pair<T2, T1>(Value2, Value1);
        }

        public Pair<C, T2> SetFst<C>(C NewFirstValue)
        {
            return new Pair<C, T2>(NewFirstValue, Value2);
        }

        public Pair<T1, C> SetSnd<C>(C NewSecondValue)
        {
            return new Pair<T1, C>(Value1, NewSecondValue);
        }
    }
}
