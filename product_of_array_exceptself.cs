public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        
        int arrLength = nums.Length;
        int[] newArr = new int[arrLength];
        newArr[0] = 1;
        for (int i = 1; i < nums.Length; i ++){
            newArr[i] = nums[i-1]* newArr[i -1];
        }

        // nums [1,2,3,4]
        // newArr [1,1,2,6]
        // i = 1
        // i = 2
        // i = 3

        // nums [1,2,3,4]
     // newArr2 [24,12,4,1]

        // nums [24,12,8,6]

        
        // due to it backwards 
        int[] newArr2 = new int[arrLength];
        newArr2[nums.Length - 1] = 1;
        for (int i = nums.Length - 2; i >= 0; i --)
        {
            newArr2[i] = nums[i + 1] * newArr2[i + 1];
        }

        for (int i =0; i < nums.Length; i ++)
        {
            nums[i] = newArr[i] * newArr2[i];
        }

        return nums;
        
    }
}
