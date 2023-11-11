public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        // go until you hit a wall 
        IList<int> result = new List<int>();
        int t = 0;
        int b = matrix.Length;
        int l = 0;
        int r = matrix[0].Length;

        while (l < r && t < b){
            // first we are going to collect the top set
            for (int i = l; i < r; i ++){
                Console.Out.WriteLine("lr"+ matrix[t][i]);
                result.Add(matrix[t][i]); 
            }

            // incremenet our top pointer 
            t += 1;

            // go throguh top to bottom 
            for (int i = t; i < b; i ++){
                result.Add(matrix[i][r-1]);
                Console.Out.WriteLine("bt"+matrix[i][r-1]);
            }

            r-= 1;
            Console.Out.WriteLine($"l:{l}, r:{r}, b:{b}, t:{t}");
            if ( r<= l || b <= t) 
            {
                return result;
            }

            // go through bottom right to bottom left
            for (int i = r -1; i >= l; i--){
                result.Add(matrix[b-1][i]);
                Console.Out.WriteLine("brl"+matrix[b-1][i]);
            }

            b-=1;

            // go through bottom left to top left
            for (int i = b -1; i >= t; i--){
                result.Add(matrix[i][l]);
                Console.Out.WriteLine("bltl"+matrix[i][l]);
            }

            l+=1;
        }

        

        return result;
        
    }
    
    
}
