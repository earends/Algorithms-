/*

Keys
- Iterate through the array with a left and a right pointer
- Move the right pointer until your target is met 
- Move the left pointer when your target is met 
*/

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int smallestWindow = 0; 
        int l = 0;
        int r = 0;
        int tempSum = 0;
        int tempWindow = 1;
        while (l < nums.Length && r < nums.Length){
            tempSum += nums[r]; // 9
            if (tempSum < target){ //  15 < 15
                
                r += 1; // 4
                tempWindow += 1; // 5
                //Console.WriteLine(r < nums.Length);
                
            }
            else {
                tempSum -= nums[l]; // 8 - 2 = 6
                tempSum -= nums[r]; // re-calculate
                l += 1; // 1
                if (smallestWindow == 0 || tempWindow < smallestWindow){
                    smallestWindow = tempWindow; // 5
                    //Console.WriteLine(smallestWindow);
                }

                if (tempWindow > 1){
                    tempWindow -= 1; // 3 
                }
                

                if (r < l){
                    r = l;
                }
            }

            Console.WriteLine(tempSum);
        }

        return smallestWindow;
    }

   
}

// 2,3,1,2,4,3
// 1,2,2,2,2,4

// w that value
// w/o that value
