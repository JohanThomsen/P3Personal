using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsOpgaver
{
    class Dict<K, V>
    {
        List<Pair<K, V>> pairs = new List<Pair<K, V>>();

        public V Get(K key)
        {
            foreach (Pair<K,V> item in pairs)
            {
                if (item.Value1.Equals(key))
                {
                    return item.Value2;
                }
            }
            throw new Exception("Key not found");
        }

        public void Put(K key, V value)
        {
            bool exists = false;

            for (int i = 0; i < pairs.Count; i++)
            {
                if (pairs[i].Value1.Equals(key))
                {
                    exists = true;
                    pairs[i] = pairs[i].SetSnd<V>(value);
                }
            }

            if (exists == false)
            {
                pairs.Add(new Pair<K, V>(key, value));
            }          
        }
    }
}
