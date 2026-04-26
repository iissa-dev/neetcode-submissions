public class Solution {
    public bool hasDuplicate(int[] nums) {
        var data = new Dictionary<int, int>();

        if (nums.Length == 0)
            return false;

        for (int i = 0; i < nums.Length; i++)
        {
            if (data.ContainsValue(nums[i]))
                return true;
            data.Add(i, nums[i]);

        }
        return false;
    }
}