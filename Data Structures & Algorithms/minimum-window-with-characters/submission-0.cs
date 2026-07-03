public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrWhiteSpace(s) || string.IsNullOrWhiteSpace(t)) return "";
        var counter = new Dictionary<char, int>();

        foreach (var c in t)
            counter[c] = counter.GetValueOrDefault(c, 0) + 1;

        int required = counter.Count;

        int r = 0, l = 0, formed = 0, startIdx = 0;
        int minLen = int.MaxValue;

        var windowCounts = new Dictionary<char, int>();
        while (r < s.Length)
        {
            char c = s[r];
            windowCounts[c] = windowCounts.GetValueOrDefault(c, 0) + 1;

            if (counter.TryGetValue(c, out int value) && windowCounts[c] == value)
            {
                formed++;
            }

            while (l <= r && formed == required)
            {
                char leftChar = s[l];
                if (r - l + 1 < minLen)
                {
                    minLen = r - l + 1;
                    startIdx = l;
                }

                windowCounts[leftChar]--;
                if (counter.TryGetValue(leftChar, out int result) && windowCounts[leftChar] < result)
                {
                    formed--;
                }

                l++;
            }

            r++;
        }

        return minLen == int.MaxValue ? "" : s.Substring(startIdx, minLen);
    }
}
