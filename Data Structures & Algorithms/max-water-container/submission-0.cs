public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0;
        int j = heights.Length - 1;
        int maxArea = 0;
        while (i < j)
        {
            int currentArea = (j - i) * Math.Min(heights[i], heights[j]);
            maxArea = Math.Max(maxArea, currentArea);
            if (heights[i] < heights[j]) i++;
            else j--;
        }

        return maxArea;
    }   
}
