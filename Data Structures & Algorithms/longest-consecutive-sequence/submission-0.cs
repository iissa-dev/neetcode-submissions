public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if (nums.Length == 0) return 0;

        var set = new HashSet<int>(nums);
        var longestStreak = 0;

        foreach (var item in set)
        {
            if (!set.Contains(item - 1))
            {
                var currentNum = item;
                var currentStreak = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentStreak += 1;
                    currentNum += 1;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}
