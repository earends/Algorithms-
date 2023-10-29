/*
Keys
- Have a dictionary that holds the valus for rows, columns, and quadrants 
- if the dictionaries contain duplicates then return false
- for the quadrant key divide the index by 3 becuase division will return the value without the remainder 
- 0/3 = 0, 1/3 = 0, 2/3 = 0, then when you get to the next quadrant 3/3 = 1
*/

public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int,List<char>> rows = new Dictionary<int,List<char>>();
        Dictionary<int,List<char>> columns = new Dictionary<int,List<char>>();
        Dictionary<string, List<char>> q = new Dictionary<string,List<char>>();
        for (int i =0; i < 9; i ++){
            for (int j = 0; j < 9; j++){
                if (board[i][j] != '.'){
                    if (rows.ContainsKey(i)){
                        if (rows[i].Contains(board[i][j])){
                            return false;
                        }
                        else {
                            rows[i].Add(board[i][j]);
                        }
                    }
                    else {
                        rows[i] = new List<char>() { board[i][j]};
                    }
                }

                if (board[i][j] != '.'){
                    if (columns.ContainsKey(j)){
                        if (columns[j].Contains(board[i][j])){
                            return false;
                        }
                        else {
                            columns[j].Add(board[i][j]);
                        }
                    }
                    else {
                        columns[j] = new List<char>() { board[i][j]};
                    }
                }

                if (board[i][j] != '.'){
                    string key = (i/3).ToString()+(j/3).ToString();
                    if (q.ContainsKey(key)){
                        if (q[key].Contains(board[i][j])){
                            return false;
                        }
                        else {
                            q[key].Add(board[i][j]);
                        }
                    }
                    else {
                        q[key] = new List<char>() { board[i][j]};
                    }
                }
            }
        }

        return true;
    }
}
