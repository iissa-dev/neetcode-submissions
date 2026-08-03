public class Solution {
    public string LongestPalindrome(string s) {
        int start = 0;
        int maxLen = 0;

        for(int i = 0; i < s.Length; i++) {
            int len1 = ExpandAroundCenter(s, i, i);
            int len2 = ExpandAroundCenter(s, i, i + 1);
            int len = Math.Max(len1, len2);

            if(len > maxLen) {
                maxLen = len;
                start = i - (len - 1) / 2;
            }
        }

        return s.Substring(start, maxLen);
    }

    private int ExpandAroundCenter(string s, int left, int right) {
        while(left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }

        return right - left - 1;
    }
}
