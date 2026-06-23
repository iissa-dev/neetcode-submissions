class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    majorityElement(nums: number[]): number {
        const size = nums.length;
        const half = size / 2;

        let counter: Record<number, number> = {};

        nums.forEach((num) => {
            if (counter[num]) counter[num]++;
            else counter[num] = 1;
        });

        for (const [key, value] of Object.entries(counter)) {
            if (value > half) return Number(key);
        }
        return 0;
    }
}
