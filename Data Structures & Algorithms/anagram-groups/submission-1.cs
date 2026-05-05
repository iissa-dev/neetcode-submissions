public class Solution {
    
    public List<List<string>> GroupAnagrams(string[] strs) {
        // With Linq To studey

        return strs
            .GroupBy(s => new string(s.OrderBy(c => c).ToArray()))
            .Select(g => g.ToList())
            .ToList();
    }
}
