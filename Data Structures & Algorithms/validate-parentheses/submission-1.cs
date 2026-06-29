public class Solution {
    public bool IsValid(string s) {
       if (s.Length == 0) return false;
        var stack = new Stack<char>();
        foreach (var ch in s)
        {
            if (ch == '(' || ch == '[' || ch == '{')
            {
                stack.Push(ch);
            }

            else
            {
                if (stack.Count != 0)
                {
                    char check = stack.Pop();
                    if (check == '(' && ch == ')' || check == '[' && ch == ']' || check == '{' && ch == '}')
                    {
                        continue;
                    }

                    else return false;
                }
                else return false;
            }
        }
        return stack.Count == 0;
    }
}
