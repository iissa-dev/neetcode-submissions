class Solution {
    /**
     * @param {number[]} prices
     * @return {number}
     */
    maxProfit(prices: number[]): number {
        let maxProfit: number = 0;
        let buy: number = prices[0]!;

        for (let i = 1; i < prices.length; i++) {
            buy = Math.min(buy, prices[i]!);
            maxProfit = Math.max(maxProfit, prices[i]! - buy);
        }

        return maxProfit;
    }
}
