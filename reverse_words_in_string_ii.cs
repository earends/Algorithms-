public class Solution {
    public string ReverseWords(string s) {
        List<string> slist = new List<string>();
        bool start = false;
        string temp = "";
        for(int i = 0; i < s.Length; i ++){
            if (s[i] == ' '){
                // reset buffer
                slist.Add(temp);
                temp = "";
            }
            else {
                temp += s[i];
            }
        }

        slist.Add(temp);

        string result = "";
        bool firstWord = true;
        for (int i = slist.Count -1; i >=0; i --){
            
                if (slist[i] == ""){
                    // skip
                }
                else if(firstWord){
result += slist[i];
firstWord = false;
                }
                else {
                    result += " "+ slist[i];
                }
                
            
            
        }

        

        return result;
    }
}
