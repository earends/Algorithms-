public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length == 0){
            return -1;
        }

        // saabutsad
        // sad

        // iterate through each haystack character 
        //    if (char matches needle[0])
        //          take the index we are at and 
        //          check to see if from where we are at to needle.Length matches
        //          if yes, return index we are at
        //          if not, move start to i + needle.Length  and continue
        //      

        for (int i =0; i < haystack.Length; i ++){
            if (haystack[i] == needle[0])
            {
                if (DoesMatch(i, haystack, needle))
                {
                    return i;
                }
            } 
            
        }    

        return -1;
    }

    private bool DoesMatch(int startingIndex, string haystack, string needle){
        // first double check that startinfindex + needle length will
        // still be long enough in haystack 

        if (startingIndex + needle.Length > haystack.Length){
            return false;
        }

        int needleStart = 0;
        for (int i = startingIndex; i < startingIndex + needle.Length; i++ ){
            if (haystack[i] != needle[needleStart]){
                return false;
            }

            needleStart+= 1;
        }

        return true;
    }


}
