public class Solution {
    public int MajorityElement(int[] nums) {
        // Voting algorithm
    int candidate = 0;
    int count = 0;

    foreach (var item in nums)
    {
        if (count == 0)
        {
            candidate = item;
            count = 1;
        }
        else if (item == candidate)
        {
            count++;
        }
        else
        {
            count--;
        }
    }

    return candidate;
    }
}