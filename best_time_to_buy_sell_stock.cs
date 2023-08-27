public class Solution {
    public int MaxProfit(int[] prices) {
        // 7 ,1 = -6 = 0
        // 7,5 = -5 = 0
        // 7, 3 = -4 = 0
        // 7, ... = 0 

        // 1, 5 = 4 
        // 1, 3 = 2
        // 1, 

        int max = prices[prices.Length - 1] - prices[0];
        int bestBuy = prices[0];
        for (int i =0; i < prices.Length - 1; i ++){
            if (prices[i] < bestBuy || i == 0){
                bestBuy = prices[i];
            }
            else {
                continue;
            }
            for (int j = i + 1; j < prices.Length; j ++){
                int tempMax = prices[j] - prices[i];
                if (tempMax > max){
                    max = tempMax;
                }
            }
        }
        if (max < 0){
            return 0;
        }

        return max;
    }
}
