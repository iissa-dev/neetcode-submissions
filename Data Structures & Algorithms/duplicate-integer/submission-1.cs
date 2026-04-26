public class Solution {
    public bool hasDuplicate(int[] nums) {
       var set = new HashSet<int>();

       foreach(int num in nums)
       {
            if(!set.Add(num))
                return true;
       }

       return false;
    }
}