public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            int j = i + 1;
            int k = nums.Length -1;
            int prev = j;
            if (i > 0 && nums[i] == nums[i-1])
                continue;
            while (j < k)
            {
                if (nums[j] + nums[k] == -(nums[i]) && nums[j] == nums[j-1] && prev < j)
                {
                    j++;
                    continue;
                }
                if (nums[j] + nums[k] == -(nums[i]))
                {
                    IList<int> temp = new List<int>();
                    temp.Add(nums[i]);
                    temp.Add(nums[j]);
                    temp.Add(nums[k]);
                    result.Add(temp);
                    j++;
                }
                if (nums[j] + nums[k] < -(nums[i]))
                {
                    j++;
                }
                if (nums[j] + nums[k] > -(nums[i]))
                {
                    k--;
                }
            }
        }
        return result;
    }
}
