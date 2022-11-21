public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        var prodExceptZero = 1;
        var zeroCount = 0;
        
        for(int i =0; i < nums.Length; i++)
        {
            if(!nums[i].Equals(0))
                prodExceptZero *= nums[i];
            else
            {
                zeroCount++;
                if(zeroCount > 1)
                    return result;
            }
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i].Equals(0))
                result[i] = prodExceptZero;
            else
            {
                if(zeroCount > 0)
                    result[i] = 0;
                else
                    result[i] = prodExceptZero / nums[i];
            }
        }

        return result;
    }
}