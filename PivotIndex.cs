public class Solution 
{
    public int PivotIndex(int[] nums) 
    {
        int leftSum = 0;
        int rightSum = 0;
        int[] prefixSum = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                prefixSum[i] = nums[i];
            }
            else
            {
                prefixSum[i] = prefixSum[i - 1] + nums[i];
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                leftSum = 0;
                rightSum = prefixSum[nums.Length -1] - prefixSum[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
            }
            if (i > 0)
            {
                leftSum = prefixSum[i -1];
                rightSum = prefixSum[nums.Length -1] - prefixSum[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
            }
        }
        return -1;
    }
}
