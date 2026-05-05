public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Linq for Studing
       var counter = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
            counter[nums[i]] = counter.GetValueOrDefault(nums[i], 0) + 1;
        

        return counter
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}
