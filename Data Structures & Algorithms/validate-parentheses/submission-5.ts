class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isValid(s: string): boolean {
        const bracketMap: Record<string, string> = {
            ")": "(",
            "]": "[",
            "}": "{",
        };

        let stack: string[] = [];

        for (const ch of s) {
            if (ch in bracketMap) {
                const topElement = stack.pop();

                if (topElement != bracketMap[ch]) return false;
            } else stack.push(ch);
        }
        return stack.length == 0;
    }
}
