class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        #create a set to hold all of the values that we have seen 
        s = {}
        #loop through each number if we have seen k - val[i] then return both indeces
        #if not add number to the set 
        for i in range(len(nums)):
            if target-nums[i] in s:
                return [s[target-nums[i]],i]
            else:
                s[nums[i]] = i
        
