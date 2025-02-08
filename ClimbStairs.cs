public class Solution {
    public static void Main(string[] args)
    {
        Console.WriteLine(ClimbStairs(3));
        Console.ReadKey();
    }
    public static int ClimbStairs(int n) {
        if (n == 1)
        {
            return 1;
        }
        if (n == 2)
        {
            return 2;
        }
        return ClimbStairs(n-1) + ClimbStairs(n-2);
    }
}
