using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsPractice.DataStructures
{
    public class HashTableNode<K, V>
    {
        public HashTableNode<K, V> Next { get; set; }
        public K Key { get; }
        public V Value { get; }

        public HashTableNode(K key, V value)
        {
            Key = key;
            Value = value;
        }

        public V Get(K key)
        {
            return Value;
        }
    }
}
