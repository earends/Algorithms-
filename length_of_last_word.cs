public class Solution {
    public int LengthOfLastWord(string s) {
        // reverse the string
        bool started = false;
        int total = 0;
        for (int i = s.Length - 1; i >= 0; i --){
            if (!started && s[i] != ' '){
                started = true;
                total += 1;
            }
            else if (started && s[i] == ' '){
                return total;
            }
            else if (started && s[i] != ' ') {
                total += 1;
            }
        }

        return total;
    }
}
