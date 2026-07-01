class Solution {
    /**
     * @param {string} s
     * @return {number}
     */
    lengthOfLongestSubstring(s: string): number {
        if (s.length === 0) return 0;
        if (s.trim().length === 0) return 1;
        let set = new Set<string>();
        let maxLen = 0;
        let l = 0;
        for (let right = 0; right < s.length; right++) {
            while (set.has(s[right]!)) {
                set.delete(s[l]!);
                l++;
            }

            set.add(s[right]!);
            maxLen = Math.max(maxLen, right - l + 1);
        }

        return maxLen;
    }
}
