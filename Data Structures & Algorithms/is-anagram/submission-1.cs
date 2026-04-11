public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if(dict.ContainsKey(c))
            {
                dict[c] += 1;
            }
            else
            {
                dict[c] = 1;
            }
        }

        foreach(char c in t)
        {
            if(dict.ContainsKey(c))
            {
                dict[c] -= 1;

                if(dict[c] == 0)
                {
                    dict.Remove(c);
                }
            }
            else
            {
                return false;
            }
        }

        return dict.Count == 0;
    }
}
