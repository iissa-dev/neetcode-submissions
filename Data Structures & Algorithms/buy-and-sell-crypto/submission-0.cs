public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int buy = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            buy = Math.Min(buy, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - buy);
        }

        return maxProfit;
    }
}
