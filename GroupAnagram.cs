public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        List<List<string>> mainResult = new List<List<string>>();
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
        foreach (string s in strs)
        {
            Char[] sArray = s.ToCharArray();
            Array.Sort(sArray);
            string sSorted = new(sArray);
            if (!result.ContainsKey(sSorted))
            {
                result.Add(sSorted, new List<string>());
            }
            result[sSorted].Add(s);
        }
        return result.Values.ToList<List<string>>();
    }
}
