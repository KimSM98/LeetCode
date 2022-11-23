public class Solution {
    int[] arr = new int[31];
    public int Fib(int n) {
        arr[0] = 0;
        arr[1] = 1;
        
        for(int i = 2, iMax = n ; i <= iMax; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }
        
        return arr[n];
    }
}