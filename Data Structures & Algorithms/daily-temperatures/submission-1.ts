class Solution {
    /**
     * @param {number[]} temperatures
     * @return {number[]}
     */
    dailyTemperatures(temperatures: number[]): number[] {
        const n = temperatures.length;
        let answer: number[] = new Array(n).fill(0);
        let stack: number[] = [];

        for (let i = 0; i < n; i++) {
            while (
                stack.length > 0 &&
                temperatures[i]! > temperatures[stack[stack.length - 1]!]!
            ) {
                let prevIdx = stack.pop()!;
                answer[prevIdx] = i - prevIdx;
            }
            stack.push(i);
        }

        return answer;
    }
}
