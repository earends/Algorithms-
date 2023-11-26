public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int>  dict = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i ++){
            int temp = target - nums[i];
            if ( dict.ContainsKey(temp)){
                return new int [] { dict[temp], i};
            }
            else {
                dict[nums[i]] = i;
            }
        }

        
        
        
        /* iterate throgh o(n*2)
        for (int i = 0; i < nums.Length; i ++){
            for (int j = i + 1; j < nums.Length; j ++){
                if (nums[i] + nums[j] == target){
                    return new int []{ i,j};
                }
            }
        }
        */

        return null;
    }
}
