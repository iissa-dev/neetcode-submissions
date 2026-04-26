public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        var found = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if(found.TryGetValue(complement, out int index))
            {
                return [index, i];
            }

            found.TryAdd(nums[i], i);
        }
    
        return [];
    }
}
