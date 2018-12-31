using System.Collections.Generic;

namespace CsPractice.Problems.Recursion
{
    public class PowerSetFinder<T>
    {
        public List<T[]> GetSubsets(T[] set)
        {
            List<T[]> subsets = new List<T[]>();
            subsets.Add(new T[0]);
            foreach (T item in set)
            {
                BuildSets(subsets, item);
            }
            return subsets;
        }

        private void BuildSets(List<T[]> subsets, T item)
        {
            int count = subsets.Count;
            for (int i = 0; i < count; i++)
            {
                T[] newSet = new T[subsets[i].Length + 1];
                if (subsets[i].Length > 0)
                {
                    subsets[i].CopyTo(newSet, 0);
                }
                newSet[newSet.Length - 1] = item;
                subsets.Add(newSet);
            }
        }
    }
}
