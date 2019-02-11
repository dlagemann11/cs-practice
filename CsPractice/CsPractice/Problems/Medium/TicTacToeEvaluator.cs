
namespace CsPractice.Problems.Medium
{
    public class TicTacToeEvaluator
    {
        public GameResult HasWon(Board board)
        {
            GameResult result = GameResult.Draw;
            Token[,] cells = board.Cells;

            if (CheckVictory(cells[0, 0], cells[0, 1], cells[0, 2], ref result)) return result;
            if (CheckVictory(cells[1, 0], cells[1, 1], cells[1, 2], ref result)) return result;
            if (CheckVictory(cells[2, 0], cells[2, 1], cells[2, 2], ref result)) return result;
            if (CheckVictory(cells[0, 0], cells[1, 0], cells[2, 0], ref result)) return result;
            if (CheckVictory(cells[0, 1], cells[1, 1], cells[2, 1], ref result)) return result;
            if (CheckVictory(cells[0, 2], cells[1, 2], cells[2, 2], ref result)) return result;
            if (CheckVictory(cells[0, 0], cells[1, 1], cells[2, 2], ref result)) return result;
            if (CheckVictory(cells[2, 0], cells[1, 1], cells[0, 2], ref result)) return result;

            return result;
        }

        private bool CheckVictory(Token first, Token second, Token third, ref GameResult result)
        {
            if (first == Token.X && second == Token.X && third == Token.X)
            {
                result = GameResult.XWins;
                return true;
            }
            if (first == Token.O && second == Token.O && third == Token.O)
            {
                result = GameResult.OWins;
                return true;
            }
            if (first == Token.None || second == Token.None || third == Token.None)
            {
                result = GameResult.NoVictory;
            }
            return false;
        }
    }

    public class Board
    {
        public Token[,] Cells { get; set; }
    }

    public enum Token
    {
        X,
        O,
        None
    }

    public enum GameResult
    {
        NoVictory,
        XWins,
        OWins,
        Draw
    }
}
