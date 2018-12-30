namespace CsPractice.Problems.Recursion
{
    public class RobotGridPathfinder
    {
        public bool[,] FindPath(bool[,] grid)
        {
            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);
            bool[,] path = new bool[rows, columns];
            bool[,] visited = new bool[rows, columns];
            if (Find(grid, path, visited, rows - 1, columns - 1))
            {
                return path;
            }
            return null;
        }

        private bool Find(bool[,] grid, bool[,] path, bool[,] visited, int row, int column)
        {
            if (!grid[row, column])
            {
                return false;
            }

            path[row, column] = true;
            if (row == 0 && column == 0)
            {
                return true;
            }
            
            visited[row, column] = true;
            bool leftFound = false;
            bool upFound = false;
            if (row > 0 && grid[row - 1, column] && !visited[row - 1, column])
            {
                leftFound = Find(grid, path, visited, row - 1, column);
            }
            if (column > 0 && grid[row, column - 1] && !visited[row, column - 1])
            {
                upFound = Find(grid, path, visited, row, column - 1);
            }

            if (!(leftFound || upFound))
            {
                path[row, column] = false;
                return false;
            }

            return true;
        }
    }
}
