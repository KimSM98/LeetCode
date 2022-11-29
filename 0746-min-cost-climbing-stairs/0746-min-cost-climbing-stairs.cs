public class Solution {
    // 인덱스 별 코스트
    int[] index = new int[1001];
    public int MinCostClimbingStairs(int[] cost) {
        var exitIdx = cost.Length;
        index[0] = cost[0];
        index[1] = cost[1];

        for(int i = 2; i <= cost.Length; i++)
        {
            index[i] = Math.Min(index[i - 2], index[i - 1]);
            if(i < exitIdx)
                index[i] += cost[i];
        }
        
        return index[exitIdx];
    }
}