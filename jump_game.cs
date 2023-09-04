public class Solution {
    public bool CanJump(int[] nums) {

        if (nums.Length == 1 && nums[0] == 0){
            return true;
        }
        
        bool numToJumpMet = true;
        int numToJumpIndex = -1;
        //  0,1,2,3,4
        // [2,0,1,0,1]
        for(int i = nums.Length - 1; i >=0; i --)
        {
            if (nums[i] == 0 && numToJumpMet)
            {
                numToJumpMet = false;
                numToJumpIndex = i; // 3
            }

            if (!numToJumpMet && (nums[i] + i > numToJumpIndex || nums[i] + i == nums.Length - 1))
            {
                numToJumpMet = true;
            }
        }

        return numToJumpMet;

        //return CanJumpInner(nums, 0);
    }

    /*
    // Solution is too slow, but I think it works
    private bool CanJumpInner(int [] nums, int startingIndex){
        if (startingIndex >= nums.Length - 1){
            return true;
        }

        if (nums[startingIndex] == 0){
            return false;
        }

        bool result = false;
        for (int i =nums[startingIndex]; i > 0; i --){
            if (startingIndex + i < nums.Length - 1 && nums[startingIndex + i] ==0){
                continue;
            }

            result = CanJumpInner(nums, startingIndex + i);
            if (result){
                return true;
            }
        }

        return result;
    }
    */
}
