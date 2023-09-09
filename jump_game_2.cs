public class Solution {
    public int Jump(int[] nums) {
        int l = 0;
        int r = 0;
        int result = 0;
        while (r < nums.Length - 1)             // 0 < 6
        {
            int maxR = r;                       // 0
            for (int i = l; i <= r; i ++ ){     
                if (i + nums[i] > maxR){        
                    maxR = i + nums[i];     // 3
                }
            }

            l = r + 1;  // 3
            r = maxR;   // 4 
            result += 1; // 2
        } 

        return result;
    }

   
}
