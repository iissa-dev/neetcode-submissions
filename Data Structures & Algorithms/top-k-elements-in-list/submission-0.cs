public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var counter = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
            counter[nums[i]] = counter.GetValueOrDefault(nums[i], 0) + 1;
        

        var list = counter.ToList();

        list.Sort((a, b) => b.Value.CompareTo(a.Value));

        var result = new List<int>();

        for (int i = 0; i < k; i++)
        {
            result.Add(list[i].Key);
        }

        return result.ToArray();
    }
}
