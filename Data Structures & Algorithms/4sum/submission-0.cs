public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
          var result = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 3; i++) 
        {

            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for (int j = i + 1; j < nums.Length - 2; j++)
            {

                if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                int a = j + 1;
                int b = nums.Length - 1;

                while (a < b)
                {
                    long sum =(long) nums[i] + nums[a] + nums[b] + nums[j];
                    if (sum == target)
                    {
                        result.Add([nums[i], nums[a], nums[b], nums[j]]);

                        while (a < b && nums[a] == nums[a + 1]) a++;
                        while (a < b && nums[b] == nums[b - 1]) b--;


                        a++;
                        b--;
                    }
                    else if (sum < target) a++;
                    else b--;
                }
            }
        }

        return result;
    }
}