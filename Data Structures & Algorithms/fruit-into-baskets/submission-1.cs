public class Solution {
    public int TotalFruit(int[] fruits) {
        var map = new Dictionary<int, int>();
        int l = 0;
        int maxFruit = 0;
        for(int r = 0; r < fruits.Length; r++) {
            int currentFruit = fruits[r];
            map[currentFruit] = map.GetValueOrDefault(currentFruit, 0) + 1;

            while(map.Count > 2) {
                int leftFruit = fruits[l];
                map[leftFruit]--;
                if(map[leftFruit] == 0)
                 map.Remove(leftFruit);

                 l++;    
            }
            maxFruit = Math.Max(maxFruit, r - l + 1);
        }
        return maxFruit;
    }
}