using System.Collections.Generic;

namespace CsPractice.Problems.ArraysAndStrings
{
    public class MatrixZeroer
    {
        public void Zero(int[,] matrix)
        {
            HashSet<int> rowSet = new HashSet<int>();
            HashSet<int> columnSet = new HashSet<int>();
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    if (matrix[row, column] == 0)
                    {
                        if (!rowSet.Contains(row))
                        {
                            rowSet.Add(row);
                        }
                        if (!columnSet.Contains(column))
                        {
                            columnSet.Add(column);
                        }
                    }
                }
            }

            foreach (int row in rowSet)
            {
                for (int i = 0; i < columns; i++)
                {
                    matrix[row, i] = 0;
                }
            }
            foreach (int column in columnSet)
            {
                for (int i = 0; i < rows; i++)
                {
                    matrix[i, column] = 0;
                }
            }
        }
    }
}
