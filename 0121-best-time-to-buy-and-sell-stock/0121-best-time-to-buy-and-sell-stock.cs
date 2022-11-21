public class Solution {
    public int MaxProfit(int[] prices) {
        // 싸게 사서 비싸게 팔기
        var result = 0;

        int left = 0;
        int right = 1;
        for(int max = prices.Length; right < max;)
        {
            result = Math.Max(result, prices[right] - prices[left]);
            if(prices[left] > prices[right])
            {
                left = right;
            }

            right++;
        }
        return result;
    }
}