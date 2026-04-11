public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                stack.Push(c);
            }
            else {
                if (stack.Count == 0) return false;

                char current = stack.Pop();

                if ((current == '(' && c != ')') ||
                    (current == '[' && c != ']') ||
                    (current == '{' && c != '}')) {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}