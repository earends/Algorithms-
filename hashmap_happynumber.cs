public class Solution {
    public bool IsHappy(int n) {
        Dictionary<int,int> previous = new Dictionary<int,int>();
        while (true){
            // convert n into a string
            string ns = n.ToString();
            
            int tempSum = 0;
            foreach(char c in ns){
                
                // pull out the int 
                int tempNum = 0;
                Int32.TryParse(c.ToString(), out tempNum);
                
                tempSum += (tempNum * tempNum);

                
            }

            

            if (tempSum ==1){
                return true;
            }
            else if (previous.ContainsKey(tempSum)){
                return false;
            }
            else {
                previous[tempSum] = 1;
            }

            n = tempSum;
        }
    }
}
