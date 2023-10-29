/*
- Keep a dictionary of characters seen
- When you run into a duplicate move your left pointer until its not seen 
- When you have a unique char move your right pointer until not unique
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0){
            return 0;
        }

        Dictionary<char,int> dict = new Dictionary<char,int>();
        int l = 0;
        int r = 0;
        int result = 0;
        int tempResult = 0;
        while (l < s.Length && r < s.Length)
        {
            // exists
            if (dict.ContainsKey(s[r]))
            {
                if (dict[s[r]] <= 0){
                    // add it 
                    dict[s[r]] = 1;
                    // incremenet result 
                    tempResult += 1;
                    if (tempResult > result){
                        result = tempResult;
                    }
                    // increment r pointer 
                    r += 1;
                }
                else 
                {
                    // remove l from the dictionary 
                    dict[s[l]] = 0;
                    tempResult -= 1;
                    l += 1;
                }
            } // does not exist
            else {
                // add it 
                dict[s[r]] = 1;
                // incremenet result 
                tempResult += 1;
                if (tempResult > result){
                    result = tempResult;
                }
                // increment r pointer 
                r += 1;
            }
        }

        return result; 
    }
}
