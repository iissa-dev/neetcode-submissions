class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums: number[]): boolean {
        let set = new Set<number>();
        for(var i of nums) {
            if(set.has(i)) return true;
            set.add(i);
        }
        return false;
    }
}
