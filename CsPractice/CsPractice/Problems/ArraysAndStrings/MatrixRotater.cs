using System;

namespace CsPractice.Problems.ArraysAndStrings
{
    public class MatrixRotater
    {
        public int[,] Rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            if (n != matrix.GetLength(1))
            {
                throw new ArgumentException("Input matrix must be NxN");
            }
            int[,] result = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    result[column, n - 1 - row] = matrix[row, column];
                }
            }

            return result;
        }

        public void RotateInPlace(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            if (size != matrix.GetLength(1))
            {
                throw new ArgumentException("Input matrix must be NxN");
            }

            int minIndex = 0;
            int maxIndex = size - 1;
            while (minIndex < maxIndex)
            {
                for (int i = 0; i < maxIndex - minIndex; i++)
                {
                    int temp = matrix[minIndex, minIndex + i];
                    matrix[minIndex, minIndex + i] = matrix[maxIndex - i, minIndex];
                    matrix[maxIndex - i, minIndex] = matrix[maxIndex, maxIndex - i];
                    matrix[maxIndex, maxIndex - i] = matrix[minIndex + i, maxIndex];
                    matrix[minIndex + i, maxIndex] = temp;
                }

                minIndex++;
                maxIndex--;
            }
        }
    }
}
