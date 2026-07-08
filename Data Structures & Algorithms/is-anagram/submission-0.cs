public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Span<int> counts = stackalloc int[256];

        foreach (char c in s) {
            counts[c]++;
        }

        foreach (char c in t) {
            if (--counts[c] < 0) {
                return false;   
            }
        }

        return true;
    }
}
