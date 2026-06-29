public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        
        while (l <= r)
        {
            int mid = (int)Math.Floor((double)l + (r - l) / 2);
            if (nums[mid] == target) return mid;

            if (nums[l] <= nums[mid])
            {
                // left is sorted
                if (target >= nums[l] && target < nums[mid])
                    r = mid - 1;
                else
                    l = mid + 1;
            }
            else
            {
                // right is sorted
                if (target > nums[mid] && target <= nums[r])
                    l = mid + 1;
                else
                    r = mid - 1;
            }
        }

        return -1;
    }
}
