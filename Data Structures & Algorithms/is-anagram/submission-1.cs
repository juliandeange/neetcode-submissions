public class Solution {
    public bool IsAnagram(string s, string t) {

        return string.Concat(s.OrderBy(i => i)) == string.Concat(t.OrderBy(i => i));

    }
}
