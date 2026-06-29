public class Solution {
    public int FindMin(int[] nums) {
        int l = 0;
        int r = nums.Length - 1;

        if (nums[l] <= nums[r]) return nums[l];

        while (l <= r)
        {
            int mid = (int)Math.Floor((double)l + (r - l) / 2);
            if (nums[mid] >= nums[mid + 1])
                return nums[mid + 1];

            if (nums[mid] <= nums[mid - 1]) return nums[mid];

            if (nums[l] <= nums[mid])
                l = mid + 1;

            else
                r = mid - 1;
        }
        return nums[l];
    }
}
