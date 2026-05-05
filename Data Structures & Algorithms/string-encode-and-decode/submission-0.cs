public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new System.Text.StringBuilder();

        foreach (var s in strs)
        {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var strs = new List<string>();
        int i = 0;

        while(i < s.Length)
        {
            int j = i;

            while (s[j] != '#')
                j++;

            int length = int.Parse(s.Substring(i, j - i));

            i = j + 1;

            string str = s.Substring(i, length);

            strs.Add(str);

            i += length;
        }

        return strs;
   }
}
