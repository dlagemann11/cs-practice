using System;

namespace CsPractice.Algorithms
{
    public class QuickSorter<T> where T : IComparable
    {
        public void QuickSort(T[] array)
        {
            if (array.Length < 2)
            {
                return;
            }
            int leftIndex = 0;
            int rightIndex = array.Length - 1;
            QuickSortHelper(array, leftIndex, rightIndex);
        }

        private void QuickSortHelper(T[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return;
            }

            int startingLeftIndex = leftIndex;
            int startingRightIndex = rightIndex;
            int pivot = leftIndex;
            T pivotValue = array[leftIndex];
            leftIndex++;

            while (leftIndex <= rightIndex)
            {
                if (array[leftIndex].CompareTo(pivotValue) >= 0)
                {
                    while (rightIndex >= leftIndex)
                    {
                        if (array[rightIndex].CompareTo(pivotValue) < 0)
                        {
                            T temp = array[leftIndex];
                            array[leftIndex] = array[rightIndex];
                            array[rightIndex] = temp;
                            rightIndex--;
                            break;
                        }

                        rightIndex--;
                    }
                }

                leftIndex++;
            }

            T tempPivot = array[pivot];
            array[pivot] = array[rightIndex];
            array[rightIndex] = tempPivot;

            QuickSortHelper(array, startingLeftIndex, rightIndex - 1);
            QuickSortHelper(array, rightIndex + 1, startingRightIndex);
        }
    }
}
