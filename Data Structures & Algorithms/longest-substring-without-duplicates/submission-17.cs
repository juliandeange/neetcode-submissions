public class Solution {
    public int LengthOfLongestSubstring(string s) {

        HashSet<char> set = new HashSet<char>();
        Queue<char> q = new Queue<char>();
        int max = 0;

        if (s == string.Empty)
            return 0;

        if (s.Length <= 1)
            return 1;

        for (int i = 0; i < s.Length; i++) {
            if (!set.Contains(s[i])) {
                // Console.WriteLine("adding: " + s[i]);
                set.Add(s[i]);
                q.Enqueue(s[i]);
            }
            else {
                // dequeue until i've removed the duplicate
                max = Math.Max(max, set.Count());
                while(set.Contains(s[i])) {
                    char removed = q.Dequeue();
                    set.Remove(removed);
                    // Console.WriteLine("removing: " + s[i]);
                }
                set.Add(s[i]);
                q.Enqueue(s[i]);


                // Console.WriteLine("storing: " + max);

                // if (q.Peek() == s[i]) {
                //     char removed = q.Dequeue();
                //     set.Remove(removed);
                //     Console.WriteLine("removing: " + removed);
                // }
                // else {
                //     while (q.Peek() != s[i]) {
                //         char removed = q.Dequeue();
                //         set.Remove(removed);
                //         Console.WriteLine("removing: " + removed);
                //     }
                // }
                // q.Enqueue(s[i]);
                // set.Add(s[i]);
            }

        }

        // Console.WriteLine("storing: " + max);

        return Math.Max(max, set.Count());
    }
}
