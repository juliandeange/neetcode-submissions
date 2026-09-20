public class Solution {

    public int rows;
    public int cols;

    public bool Exist(char[][] board, string word) {

        rows = board.Length;
        cols = board[0].Length;

        for (int i = 0; i < board.Length; i++) {
            for (int j = 0; j < board[0].Length; j++) {

                if (board[i][j] == word[0]) {
                    bool result = Search(board, word, i, j, 0);
                    if (result)
                        return true;
                }

            }
        }
        return false;
    }

    public bool Search(char[][] board, string word, int row, int col, int index) {

        if (word[index] != board[row][col])
            return false;

        if (index == word.Length - 1)
            return true;

        char og = word[index];
        board[row][col] = '#';

        // Search right
        if (col + 1 < cols) {
            if (Search(board, word, row, col + 1, index + 1))
                return true;
        }

        // Search down
        if (row + 1 < rows) {
            if (Search(board, word, row + 1, col, index + 1))
                return true;
        }

        // Search left
        if (col - 1 >= 0) {
            if (Search(board, word, row, col - 1, index + 1))
                return true;
        }

        // Search up
                // Search down
        if (row - 1 >= 0) {
            if (Search(board, word, row - 1, col, index + 1))
                return true;
        }

        board[row][col] = og;

        return false;

    }

}
