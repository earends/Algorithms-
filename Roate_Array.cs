public class Solution {
    public void Rotate(int[] nums, int k) {
        // [1,2,3,4,5,6,7] 6 + 3 = 9 % 6 = 3
        // [5,6,7,1,2,3,4] 3 + 2 % 6 

        if (k == 0 || nums.Length == 1)
            return;

        int [] tempArr = new int [nums.Length];
        for(int i = 0; i < nums.Length; i ++){
            int newIndex = i + k; // 1 + 1 = 2
            if (newIndex / nums.Length >= 1){
                tempArr[newIndex % nums.Length] = nums[i];
            }
            else {
                tempArr[newIndex] = nums[i];
            }
            

            
        }

        for(int i = 0; i < nums.Length; i ++){
            nums[i] = tempArr[i];
        }


    }
}
