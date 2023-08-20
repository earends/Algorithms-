/*
Remove element starts with an array of numbers and a value to match and asks you to remove all occurances
of the value in the array. 
The goal is to shift all of the values found to the back of the array, and then return the total number
of values in the array kept. 

We shift all the values to the back of the array, because the answer is only looking for the first X numbers 
in the array.
*/

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        // return length of the array - number of elements removed
        int k = 0;
        int numsc = nums.Length - 1;
        int replacec = nums.Length - 1;
        while (numsc >= 0){
            if (nums[numsc] == val){
                int temp = nums[numsc]; 
                nums[numsc] = nums[replacec]; 
                nums[replacec] = temp; 
                replacec -= 1; 
                k += 1; 
            }

            numsc -= 1;

            //Console.WriteLine(string.Join(",",nums));
        }

        return nums.Length - k;
    }
}
