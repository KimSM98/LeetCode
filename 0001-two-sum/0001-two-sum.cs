public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int i = 0;
        int j = 0;
        for( i = 0; i < nums.Length - 1; i++)
        {
            for(j = i +1; j<nums.Length; j++)
            {
                var result = nums[i] + nums[j];
                if(target.Equals(result))
                {
                    return new int[]{i, j};
                }
            }
        }
        return new int[]{i, j};
    }
}