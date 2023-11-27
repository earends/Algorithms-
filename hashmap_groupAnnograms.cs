public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        // first you have to know if one is an anagram 
        // take first word compare to all other words 
        // if you find an anagram 
            // add to list 
            // exclude anograms already seen by adding to a dictionary 

        IList<IList<string>> result = new List<IList<string>>();

        Dictionary<int,int> found = new Dictionary<int,int>();
        for(int i = 0; i < strs.Length; i ++){
            if (found.ContainsKey(i)){
                continue;
            }

            List<string> temp = new List<string>();
            temp.Add (strs[i]);

            for (int j = i + 1; j <strs.Length; j ++){
                if (found.ContainsKey(j)){
                    continue;
                }

                if (IsAnagram(strs[j], strs[i]) ){
                    temp.Add(strs[j]);
                    found[j] = j;
                }
            }

            result.Add(temp);
        }

        return result;
         
    }

    public bool IsAnagram(string s, string s1)
    {
        
        if (s1.Length != s.Length){
            return false;
        }

        Dictionary<char,int> dict = new Dictionary<char,int>();
        foreach(char c in s){
            if (!dict.ContainsKey(c))
            {
                dict[c] = 1;
            }
            else {
                dict[c] += 1;
            }


        }

        foreach(char c in s1){
            if (!dict.ContainsKey(c))
            {
                return false;
            }
            else if (dict.ContainsKey(c) && dict[c] > 0) {
                dict[c] -= 1;
            }
            else {
                return false;
            }
        }

        return true;
    }
}
