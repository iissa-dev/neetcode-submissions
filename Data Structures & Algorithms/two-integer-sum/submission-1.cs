public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
          var found = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {

            if(found.TryGetValue(nums[i], out int value))
            {
                return [value, i];
            }

            found.Add(target - nums[i], i);

        }
        
        

        return [0, 0];
    }
}
