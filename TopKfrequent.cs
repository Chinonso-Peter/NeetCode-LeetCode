public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var freq = new Dictionary<int, int>();
        int[] res = new int[k];
        
        foreach (var num in nums)
        {
            if (freq.ContainsKey(num))
            {
                freq[num]++;
            }    
            else
            {
                freq[num] = 1;
            }
        }
        for (int i = k; i > 0; i--)
        {
            var num = freq.MaxBy(x => x.Value);
            int ans = num.Key;
            res[i - 1] = ans;
            freq.Remove(num.Key);
        }
        return res;
    }
}
