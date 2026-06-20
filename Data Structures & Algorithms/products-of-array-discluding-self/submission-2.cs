public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int size = nums.Length;
        int[] prefix = new int[size];
        int[] suffix = new int[size];
        int[] result = new int[size];

        prefix[0] = 1;
        for (int i = 1; i < size; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }


        suffix[size - 1] = 1;
        for (int i = size - 2; i >= 0; i--)
        {
            suffix[i] = suffix[i + 1] * nums[i + 1];
        }

        for (int i = 0; i < size; i++)
        {
            result[i] = prefix[i] * suffix[i];
        }
        return result;
    }
}
