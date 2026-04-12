public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int profit = 0;

        foreach(int price in prices)
        {
            if(price < min)
            {
                min = price;
            }
            else if(profit < price - min)
            {
                profit = price - min;
            }
        }

        return profit;
    }
}
