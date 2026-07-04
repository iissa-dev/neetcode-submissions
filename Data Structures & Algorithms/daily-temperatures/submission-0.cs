public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] answer = new int[n];
        var stack = new Stack<int>();

        for(int i = 0; i < n; i++) {

            while(stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
                int prevIdx = stack.Pop();
                answer[prevIdx] = i - prevIdx;
            }
            stack.Push(i);
        }

        return answer;
    }
}
