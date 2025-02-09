public class NumArray {
    int[] numsArr;
    public NumArray(int[] nums) 
    {
        numsArr = nums;
    }
    
    public int SumRange(int left, int right) 
    {
        int result = 0;
        for (int i = left; i <= right; i++)
        {
            result += numsArr[i];
        }
        return result;
    }
}
