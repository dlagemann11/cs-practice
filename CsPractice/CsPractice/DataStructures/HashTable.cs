using System;

namespace CsPractice.DataStructures
{
    public class HashTable<K, V> where K : IEquatable<K>
    {
        private HashTableNode<K, V>[] array;
        private int arrayCount;

        public HashTable() : this(1) { }

        public HashTable(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Initial size must be greater than zero.");
            }
            array = new HashTableNode<K, V>[size];
            arrayCount = 0;
        }

        public void Add(K key, V value)
        {
            if (arrayCount == array.Length)
            {
                IncreaseSize();
            }

            int index = GetIndex(key);
            Append(index, new HashTableNode<K, V>(key, value));
            arrayCount++;
        }
            
        public V Get(K key)
        {
            int index = GetIndex(key);
            HashTableNode<K, V> node = GetNode(array[index], key);
            return node.Value;
        }

        public V Take(K key)
        {
            int index = GetIndex(key);
            HashTableNode<K, V> node = GetNode(array[index], key);
            V value = node.Value;
            DeleteNode(index, node);
            arrayCount--;
            return value;
        }

        public void Delete(K key)
        {
            int index = GetIndex(key);
            HashTableNode<K, V> node = GetNode(array[index], key);
            DeleteNode(index, node);
            arrayCount--;
            return;
        }

        private int GetIndex(K key)
        {
            int hashCode = key.GetHashCode();
            return hashCode % array.Length;
        }

        private void IncreaseSize()
        {
            HashTableNode<K, V>[] newArray = new HashTableNode<K, V>[Math.Max(1, array.Length * 2)];
            HashTableNode<K, V>[] oldArray = array;
            array = newArray;
            arrayCount = 0;

            for (int i = 0; i < oldArray.Length; i++)
            {
                HashTableNode<K, V> node = oldArray[i];
                while (node != null)
                {
                    Add(node.Key, node.Value);
                    node = node.Next;
                }
            }
        }

        private void Append(int index, HashTableNode<K, V> newNode)
        {
            if (array[index] == null)
            {
                array[index] = newNode;
                return;
            }

            HashTableNode<K, V> node = array[index];
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = newNode;
        }

        private HashTableNode<K, V> GetNode(HashTableNode<K, V> node, K key)
        {
            while (node != null)
            {
                if (node.Key.Equals(key))
                {
                    return node;
                }
                node = node.Next;
            }

            throw new KeyNotFoundException();
        }

        private void DeleteNode(int index, HashTableNode<K, V> nodeToDelete)
        {
            if (array[index] == nodeToDelete)
            {
                array[index] = null;
                return;
            }

            HashTableNode<K, V> node = array[index];
            while (node.Next != nodeToDelete)
            {
                node = node.Next;
            }

            if (node.Next.Next != null)
            {
                node.Next = node.Next.Next;
            }
            else
            {
                node.Next = null;
            }            
        }
    }

    public class KeyNotFoundException : Exception {}
}
