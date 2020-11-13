using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Opgaver
{
    class Sequence : IEnumerable<int>
    {
        List<int> sequenceList = new List<int>();

        public int Start { get; set; }
        public int Skip { get; set; }
        public int Count { get; set; }

        public Sequence(int start,int skip,int count)
        {
            Start = start;
            Skip = skip;
            Count = count;
            createSequence();
        }

        private void createSequence()
        {
            for (int i = 0; i < Count; i++)
            {
                sequenceList.Add(Start + (i * Skip));
            }
        }
        public int this[int index]
        {
            get { return sequenceList[index]; }
            set { sequenceList.Insert(index,value); }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return sequenceList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
