public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var dic = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(!dic.ContainsKey(nums[i]))
                dic.Add(nums[i], i);
            else
                return true;
        }
        return false;
    }
}