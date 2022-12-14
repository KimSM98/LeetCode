public class Solution {
    int[] arr = new int[46];
    public int ClimbStairs(int n) {
        
        arr[1] = 1;
        arr[2] = 2;

        for(int i = 3; i <= n; i++)
        {
            arr[i] = arr[i - 2] + arr[i - 1];
        }

        return arr[n];
    }
}