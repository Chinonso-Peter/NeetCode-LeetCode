public class Solution {

    public string Encode(IList<string> strs) 
    {
        if (strs.Count == 0) return "";
        if (strs.Count == 1 && strs.Contains(""))
        {
            strs[0] = "\n";
        }
        return string.Join("\n", strs);

    }

    public List<string> Decode(string s) 
    {
        if (s.Length == 0) return new List<string>();
        if(s.Length ==1 && s.Contains("\n"))
        {
            s = s.Replace("\n", "");
        }
        return new List<string>(s.Split("\n"));
    }
}
