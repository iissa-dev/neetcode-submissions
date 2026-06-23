class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isPalindrome(s: string): boolean {
        let left = 0;
        let right = s.length - 1;

        const isAlphanumeric = (char: string) => /^[a-z0-9]$/i.test(char);
        while (left < right) {
            if (!isAlphanumeric(s[left]!)) left++;
            else if (!isAlphanumeric(s[right]!)) right--;
            else {
                if (s[left]?.toLowerCase() !== s[right]?.toLowerCase()) return false;

                left++;
                right--;
            }
        }

        return true;
    }
}
