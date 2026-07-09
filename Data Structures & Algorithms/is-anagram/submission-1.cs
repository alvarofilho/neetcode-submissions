public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        Span<int> counts = stackalloc int[256];

        for (int i = 0; i < s.Length; i++) {
            counts[s[i]]++;
            counts[t[i]]--;
        }

        for (int i = 0; i < counts.Length; i++) {
            if (counts[i] != 0) {
                return false;
            }
        }

        return true;
    }
}