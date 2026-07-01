public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        if(s.Trim().Length == 0) return 1;

        var set = new HashSet<char>();
        int l = 0;
        int maxLen = 0;
        for (int r = 0; r < s.Length ; r++)
        {
            while (set.Contains(s[r]))
            {
                set.Remove(s[l]);
                l++;
            }

            set.Add(s[r]);
            maxLen = Math.Max(maxLen, r - l + 1);
        }
        return maxLen;
    }
}
