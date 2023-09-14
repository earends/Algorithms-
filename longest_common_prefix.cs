public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = "";
        int startingIndex = 0;
        while (true){
            char prev = 'A'; 
            foreach(string str in strs){
                // check to see if we have reached the length of a string
                if (startingIndex > str.Length - 1){
                    return result;
                }
                // check to see if the previous char matches 
                if (prev != 'A' && prev != str[startingIndex] ){
                    return result;
                }

                prev = str[startingIndex];
            }

            // if we get to the end then we can add the index char to our string

            result += strs[0][startingIndex];
            startingIndex += 1;
        }

        return result;
    }
}
