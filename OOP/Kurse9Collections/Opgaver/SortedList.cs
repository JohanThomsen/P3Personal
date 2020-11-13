using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Opgaver
{
    class SortedList<T> : ICollection<T> where T : IComparable<T>
    {
        List<T> items = new List<T>();

        public int Count => items.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            items.Add(item);
            items.Sort();
        }

        public void Clear()
        {
            items.Clear();
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return items.Remove(item);
        }

        public List<T> GetElementsReversed()
        {
            List<T> tempList = new List<T>();
            for (int i = Count - 1; i >= 0; i--)
            {
                tempList.Add(items[i]);
            }
            return tempList;
        }

        public List<T> GetElements(Predicate<T> pred)
        {
            List<T> tempList = new List<T>();

            tempList = items.FindAll(pred);
            tempList.Sort();

            return tempList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
