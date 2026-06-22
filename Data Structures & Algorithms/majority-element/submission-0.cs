public class Solution {
    public int MajorityElement(int[] nums) {
        int size = nums.Length;
        int halfOnSize = size / 2;

        var counter = new Dictionary<int, int>();
        for(int i = 0; i < size; i++)
        {

            counter[nums[i]] = counter.GetValueOrDefault(nums[i], 0) + 1;

        }

        foreach(var kvp in counter)
        {

            if(kvp.Value > halfOnSize)

                return kvp.Key;

        }

        return 0;
    }
}