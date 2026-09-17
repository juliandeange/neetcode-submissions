public class Solution {

    public int rows;
    public int cols;

    public bool Exist(char[][] board, string word) {

        rows = board.Length;
        cols = board[0].Length;
        int index = 0;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {

                if (Search(board, i, j, word, index))
                    return true;

            }
        }
        return false;
    }

    public bool Search(char[][] board, int row, int col, string word, int index) {

        // if OOB or its not the letter --> return false
        if (row >= rows ||
            col >= cols ||
            row < 0 ||
            col < 0 ||
            board[row][col] != word[index]) {
                return false;
            }
        Console.WriteLine("found: " + word[index]);

        Console.WriteLine(index);

        // if index == word.Length --> return true
        if (index == word.Length - 1)
            return true;

        // mark the spot as used
        char og = word[index];
        board[row][col] = '#';

        // search again
        // check right
        bool right = Search(board, row, col + 1, word, index + 1);
        // check down
        bool down = Search(board, row - 1, col, word, index + 1);
        // check left
        bool left = Search(board, row, col - 1, word, index + 1);
        // check up
        bool up = Search(board, row + 1, col, word, index + 1);
        // Search(board, )

        // if route not found then replace original character
        board[row][col] = og;

        return left || down || right || up;

    }
}
