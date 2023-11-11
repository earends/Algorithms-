public class Solution {
    public void Rotate(int[][] matrix) {
        int l = matrix.Length;
        for (int i = 0; i < matrix.Length/2; i ++){
            for (int j = i; j < matrix.Length-i-1; j ++)
            {
                int temp = matrix[i][j];

                matrix[i][j] = matrix[l - j -1][i]; 

                matrix[l - j -1][i] = matrix[l - i -1][l - j -1];

                matrix[l - i -1][l - j -1] = matrix[j][l-i-1];

                matrix[j][l-i-1] = temp;
            }
        }
    }
}

// 7,4,3
// 8,5,2
// 9,6,1
