public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0;
        int maxRepate = 0;
        int maxLen = 0;
        var map = new Dictionary<char, int>();

        for(int right = 0; right < s.Length; right++) {
            char currentChar = s[right];
            map[currentChar] = map.GetValueOrDefault(currentChar, 0) + 1;
            maxRepate = Math.Max(maxRepate, map[currentChar]);
            while((right - left + 1) - maxRepate > k) {
                char leftChar = s[left];
                map[leftChar]--;
                left++;
            }

            maxLen = Math.Max(maxLen, right - left + 1);
        }
        return maxLen;
    }
}
