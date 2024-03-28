public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var existingValues = new HashSet<string>();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board.Length; j++)
            {
                if (board[i][j] == '.') continue;
                else if (!existingValues.Add(board[i][j] + " row " + j) ||
                    !existingValues.Add(board[i][j] + " coulmn " + i) ||
                    !existingValues.Add(board[i][j] + " " + i / 3 +
                    " - " + j / 3 + " box"))
                {
                    return false;
                }
            }
        }
        return true;
    }
}