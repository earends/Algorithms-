public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if (t.Length > s.Length){
            return false;
        }
        Dictionary<char,int> dict = new Dictionary<char,int>();
        for (int i = 0; i < t.Length; i ++){
            if (!dict.ContainsKey(t[i])){
                dict[t[i]] = 1;
            }
            else {
                dict[t[i]] += 1;
            }
        }

        foreach(char c in s){
            if (!dict.ContainsKey(c) ||  dict[c] < 1){
                return false;
            }
            else {
                dict[c] -=1;
            }
        }

        return true;
    }
}
