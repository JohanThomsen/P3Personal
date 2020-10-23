using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GenericsOpgaver
{
    class HandyMethods
    {

        public T Max<T>(List<T> list) where T : IComparable<T> 
        {
            return list.Max();
        }

        public T Min<T>(List<T> list) where T : IComparable<T>
        {
            return list.Min();
        }

        public void Copy<T>(T[] arr1, T[] arr2)
        {
            T temp;
            if (arr1.Length  == arr2.Length)
            {
                int arrayLength = arr1.Length;

                for (int i = 0; i < arrayLength; i++)
                {
                    temp = arr1[i];
                    arr1[i] = arr2[arr2.Length - i - 1];
                    arr2[arrayLength - i - 1] = temp;
                }
            } else
            {
                throw new Exception("Arrays must be equal length");
            }
        }
    }
}
