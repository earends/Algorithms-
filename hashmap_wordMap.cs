/*
Need to create an extra dictionary to filter out duplicates 
If pattern length does not equal words length then return false
*/

public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<string,string> duplicateMappings = new Dictionary<string,string>();
        Dictionary<char,string> mapping = new Dictionary<char,string>();
        string[] words = s.Split(" ");
        if (words.Length != pattern.Length){
            return false;
        }

        for (int i = 0; i < words.Length; i ++){
            //Console.WriteLine($"{i}, {i % pattern.Length} {words.Length}");
            if (mapping.ContainsKey(pattern[i % pattern.Length]) 
            && mapping[pattern[i % pattern.Length]] != words[i]){
                return false;
            }
            else if (mapping.ContainsKey(pattern[i% pattern.Length])){
                // do nothing
            }
            else if (!mapping.ContainsKey(pattern[i% pattern.Length])){

                if (duplicateMappings.ContainsKey(words[i])){
                    return false;
                }

                mapping[pattern[i% pattern.Length]] = words[i];
                duplicateMappings[words[i]] = words[i];
            }
        }

        return true;
    }
}
