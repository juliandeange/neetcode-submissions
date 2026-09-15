public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string s in strs) {

            string ordered = string.Concat(s.OrderBy(e => e));
            // Console.WriteLine(ordered);
            if (anagrams.ContainsKey(ordered))
                anagrams[ordered].Add(s);
            else {
                anagrams.Add(ordered, new List<string>());
                anagrams[ordered].Add(s);
            }


        }

        return anagrams.Values.ToList();
        
    }
}
