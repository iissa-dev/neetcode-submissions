class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number}
     */
    search(nums: number[], target: number): number {
        let l = 0;
        let r = nums.length - 1;

        while (l <= r) {
            const mid = Math.floor(l + (r - l) / 2);

            if (nums[mid] === target) return mid;

            if (nums[l]! <= nums[mid]!) {
                // left sorted

                if (target >= nums[l]! && target < nums[mid]!) {
                    r = mid - 1;
                } else l = mid + 1;
            } else {
                // right sorted

                if (target > nums[mid]! && target <= nums[r]!) {
                    l = mid + 1;
                } else r = mid - 1;
            }
        }

        return -1;
    }
}
