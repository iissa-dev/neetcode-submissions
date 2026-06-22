public class Solution {
    public bool IsValidSudoku(char[][] board) {
         var seen = new HashSet<string>();
        
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board.Length; col++)
            {
                char number = board[row][col];
                
                if (number == '.')
                {
                    continue;
                }
                
                if (!seen.Add($"{number} in row {row}")
                 || !seen.Add($"{number} in col {col}")
                 || !seen.Add($"{number} in box {row / 3}-{col / 3}"))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
