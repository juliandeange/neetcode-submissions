public class Solution {
    public bool IsAnagram(string s, string t) {

        string sSorted = string.Concat(s.OrderBy(i => i));
        string tSorted = string.Concat(t.OrderBy(i => i));

        return sSorted == tSorted;

    }
}
