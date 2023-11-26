public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,char> dict = new Dictionary<char,char>();
        Dictionary<char,int> mappings = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i ++){
            if (!dict.ContainsKey(s[i])){
                if (mappings.ContainsKey(t[i])){
                    return false;
                }
                dict[s[i]] = t[i];
                mappings[t[i]] = 1;
            }
            else if (dict[s[i]] != t[i]){
                return false;
            }
        }

        return true;
    }
}
