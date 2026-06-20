class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    productExceptSelf(nums: number[]): number[] {
        const size = nums.length;
        let prefix: number[] = new Array(size).fill(1);
        let suffix: number[] = new Array(size).fill(1);
        let result: number[] = new Array(size).fill(1);

        for (let i = 1; i < size; i++) {
            prefix[i] = prefix[i - 1]! * nums[i - 1]!;
        }

        for (let i = size - 2; i >= 0; i--) {
            suffix[i] = suffix[i + 1]! * nums[i + 1]!;
        }

        for (let i = 0; i < size; i++) {
            result[i] = prefix[i]! * suffix[i]!;
        }
        return result;
    }
}
