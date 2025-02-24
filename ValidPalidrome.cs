public class Solution {
    public bool IsPalindrome(string s) 
    {
        if (s.Length == 0)
        {
            return true;
        }
        s = s.ToLower();
        StringBuilder myString = new StringBuilder(); 
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                myString.Append(c);
            }
        }
        int n = myString.Length;
        System.Console.WriteLine(n);
        for (int i = 0; i < n; i++)
        {
            if (myString[i] == myString[n - 1 - i])
            {
                continue;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
