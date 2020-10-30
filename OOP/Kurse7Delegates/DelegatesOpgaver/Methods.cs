using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesOpgaver
{
    public delegate string StringJoin(string l, string r);
    public delegate T Join<T>(T Tin1, T Tin2);
    class Methods
    {
        public string JoinThree(string str1, string str2, string str3, StringJoin join)
        { 
            string newString;

            newString = join(str1, str2);
            newString = join(newString, str3);

            return newString;
        }

        public string JoinAllStrings(List<string> strings, StringJoin join)
        {
            string newString = strings[0];
            for (int i = 1; i <= strings.Count - 1; i++)
            {
                newString = join(newString, strings[i]);
            }
            return newString;
        }

        public T JoinAll<T>(List<T> items, Join<T> join)
        {
            T combined = items[0];

            for (int i = 1; i <= items.Count - 1; i++)
            {
                combined = join(combined, items[i]);
            }

            return combined;
        }

        public bool Exists<T>(Predicate<T> pred, T[] arr)
        {
            bool result = false;
            foreach (T item in arr)
            {
                if (pred(item))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
