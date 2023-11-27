public class Solution {
    public int LongestConsecutive(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int num in nums){
            if (!dict.ContainsKey(num)){
                dict[num] = 0;
            }
        }

        int result = 0;
        for (int i = 0; i < nums.Length; i ++){
            if (dict[nums[i]] > 0){
                continue;
            }

            dict[nums[i]] = 1;

            int tempCount = 1;

            

            int lowernum = nums[i];
            while (dict.ContainsKey(lowernum - 1)){
                tempCount += 1;
                dict[lowernum] = 1;
                lowernum -= 1;
                
            }

            int uppernum = nums[i];
            while (dict.ContainsKey(uppernum + 1)){
                tempCount += 1;
                dict[uppernum] = 1;
                uppernum += 1;
                
            }

            if (tempCount > result){
                result = tempCount;
            }
        }

        return result;
        /* {
            {100, 0},
            {4, 0 },
            {200, 0},
            {1,0},
            {3, 0 },
            {2, 0 }


        }

        dict seen = {}
        int count = 0
        for num in range nums

            if (num in seen){
                continue;
            }

            seen.Add(num);

            int tempCount = 1
            int lowerNum = num;
            while  (lowernum -1 in dict):
                tempCount += 1;
                seen.Add(lowernum);

            while (uppernum + 1 in dict):
                tempCount += 1;
                seen.Add(uppernum)

            if (count < tempNum)
                count = tempNum

        return count;

        */
    }
}
