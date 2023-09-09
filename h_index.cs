public class Solution {
    public int HIndex(int[] citations) {
        

        Array.Sort(citations);
        //int index = 1;
        //0,1,3,5,6
        // 5 papers with 0 citations, 5 > 0
        // 4 papers with 1 citations 4 > 1 
        // 3 papers with 3 citations 3 >= 3
        // 2 papers with 5 citatations 2 < 5 STOP 

        // 100 
        // 1 papers with 100 citations 

        // 4 , 4, 6 = 3
        // 7,7,7,7 = 4 
        // 6,7,7,7
        // 4,
        // 3,6,6. = 3
        // 2,6,6 = 2
        // 6,6,6 
        // 100 
        // 1,1,1
        // 3 papers with 4 citations 3 < 4 STOP

        if (citations[citations.Length - 1] == 0){
            return 0;
        }

        int result = 1;
        for(int i = citations.Length - 1; i >=0; i --){
            if (isValid(citations[i], citations.Length - i))
            {
                return GetMax(citations[i],result);
            }
            else {
                if (citations.Length - i < citations[i]){
                    result =  citations.Length - i;
                }
            }
            
            
        }
        // 0,0,4,4


        return result;
    }

    public bool isValid(int citations, int numPapers){
        // do we have num papers = citations 
        if (numPapers >= citations){
            return true;
        }
        else {
            return false;
        }
    }

    private int GetMax(int a, int b){
        if (a > b){
            return a;
        }
        else {
            return b;
        }
    }
}
