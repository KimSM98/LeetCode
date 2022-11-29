public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length < 2)
            return nums[0];

        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = nums[1];

        var selectableVal = 0;
        var max = Math.Max(dp[0], dp[1]);

        for(int i = 2; i < nums.Length; i++)
        {
            selectableVal = Math.Max(selectableVal, dp[i-2]);
            dp[i] = selectableVal + nums[i];
            
            max = Math.Max(max, dp[i]);
        }

        return max;
    }
}