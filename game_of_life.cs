public class Solution {
    private const int DEAD_PREVIOUSLY_ALIVE=2;
    private const int AlIVE_PREVIOUSLY_DEAD=3;
    public void GameOfLife(int[][] board) {
        
        

        for (int i =0; i < board.Length; i ++){
            for (int j = 0; j < board[0].Length; j ++){
                int ln = GetLiveNeighbors(i,j,board);
                if (board[i][j] == 1 && ln < 2 ){
                    board[i][j] = DEAD_PREVIOUSLY_ALIVE;
                }
                else if (board[i][j] == 1 && (ln == 2 || ln ==3)){
                    // no op
                }
                else if (board[i][j] == 1 && ln > 3){
                    board[i][j] = DEAD_PREVIOUSLY_ALIVE;
                }
                else if (board[i][j] == 0 && ln == 3){
                    board[i][j] = AlIVE_PREVIOUSLY_DEAD;
                }

            }
        }

        for (int i =0; i < board.Length; i ++){
            for (int j = 0; j < board[0].Length; j ++){
                
                if (board[i][j] ==  AlIVE_PREVIOUSLY_DEAD){
                    board[i][j] = 1;
                }
                else if (board[i][j] ==  DEAD_PREVIOUSLY_ALIVE){
                board[i][j] = 0;
                }

            }
        }

    }

    public int GetLiveNeighbors(int i, int j, int[][] board){
        int live = 0;
        // top left corner
        if (i -1 >= 0 && j - 1 >= 0 
        && (board[i-1][j-1] == 1 || board[i-1][j-1] == 2))
        {
            live +=1;
        }

        // top middle
        if (i -1 >= 0 && (board[i-1][j] == 1 ||board[i-1][j] == 2)) 
        {
            live +=1;
        }

        // top right
        if (i -1 >= 0 && j + 1 < board[0].Length 
        && (board[i-1][j+1] == 1 || board[i-1][j+1] == 2))
        {
            live +=1;
        }
        // middle right
        if ( j + 1 < board[0].Length 
        && (board[i][j+1] == 1 || board[i][j+1] == 2))
        {
            live +=1;
        }

        // lower bottom right corner
        if (i + 1 < board.Length && j + 1 < board[0].Length 
        && (board[i+1][j+1] == 1 || board[i+1][j+1] == 1))
        {
            live +=1;
        }

        // lower bottom middle 
        if (i + 1 < board.Length  
        && (board[i+ 1][j] == 1 ||board[i+ 1][j] == 2))
        {
            live +=1;
        }

        // lower bottom left
        if (i +1 < board.Length && j - 1 >= 0 
        && (board[i+1][j-1] == 1 || board[i+1][j-1] == 2))
        {
            live +=1;
        }

        // lower middle left
        if (j - 1 >= 0 
        && (board[i][j-1] == 1 || board[i][j-1] == 2))
        {
            live +=1;
        }

        return live;
    }
}
