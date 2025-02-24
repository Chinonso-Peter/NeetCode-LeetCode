public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if (nums.Length == 0)
            return 0;
        int currentLength = 0;
        int maxLength = 0;
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            AddToDic(nums[i], dic);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (!nums.Contains(nums[i] -1))
            {
                currentLength = 1;
                while (dic.ContainsKey(nums[i] + 1))
                {
                    currentLength ++;
                    nums[i] ++;
                }

            }
            maxLength = Math.Max(maxLength, currentLength);
            currentLength = 0;
        }
        return maxLength;
        
    }
    public void AddToDic (int num, Dictionary<int, int> dic)
    {
        if (dic.ContainsKey(num))
        {
            dic[num] = dic[num] + 1;
        }
        else
        {
            dic.Add(num, 1);
        }
    }
}
