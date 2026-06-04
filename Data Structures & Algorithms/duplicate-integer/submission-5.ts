class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums: number[]): boolean {
        const uniqueNums = new Set(nums);
        return uniqueNums.size !== nums.length;
    }
}
