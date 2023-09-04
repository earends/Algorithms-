public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit =0;
        int prevValue = prices[0];
        foreach(int val in prices){
            if (val > prevValue){
                maxProfit += (val - prevValue);

            }

            prevValue = val;
        }

        return maxProfit;
    }
}
