public class Solution {
    public bool IsAnagram(string s, string t) {
        var count = new Dictionary<char, int>();
        if (s.Length != t.Length)
            return false;

        for (int i = 0; i < s.Length; i++)
        {
            count[s[i]] = count.GetValueOrDefault(s[i], 0) + 1;
            count[t[i]] = count.GetValueOrDefault(t[i], 0) - 1; 
        }

        foreach (var c in count)
        {
            if (c.Value != 0)
                return false;
        }

        return true;
    }
}
