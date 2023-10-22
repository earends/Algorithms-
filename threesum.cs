/*

Keys
- sort the array before hand
- as you are iterating through the array exclude duplicates 
- as you are iterating through left and right pointers once you find a match 
iterate the left pointer and iterate until you find non duplicate left hand pointers 
*/


public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {

        Array.Sort(nums);
        Console.WriteLine(String.Join(",",nums));
        IList<IList<int>> result = new List<IList<int>>();
        //return result;
        for(int i = 0; i < nums.Length -2; i ++){
            if (i != 0 && nums[i] == nums[i-1])
            {
                continue;
            }
            
            int l = i + 1;
            int r = nums.Length -1;
            while (l < r){
                int tempSum = nums[i] + nums[l] + nums[r];
                
                 if (tempSum == 0){
                    IList<int> tempList = new List<int>();
                    tempList.Add(nums[i]);
                    tempList.Add(nums[l]);
                    tempList.Add(nums[r]);
                    result.Add(tempList);
                    l+=1;
                    while (l < r && nums[l] == nums[l-1]){
                        l += 1;
                    }

                }
                else if (tempSum > 0){
                    r -= 1;
                }
                else {
                    l +=1;
                }
            }   
            
        }
        

        return result;
    }

    
}

// -1,-1,2 

// [-4,-1,-1,0,1,2]
// 

    
