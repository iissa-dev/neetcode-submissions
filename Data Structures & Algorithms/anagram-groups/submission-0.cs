public class Solution {
    
    public List<List<string>> GroupAnagrams(string[] strs) {

        var map = new Dictionary<string, List<string>>();

        foreach(var word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new(chars);

            if(!map.ContainsKey(key))
                map[key] = [];

            map[key].Add(word);
        }

        return map.Values.Select(x => x).ToList();
    }
}
