public class Solution {
    public bool IsValid(string s) {
        
        Dictionary<char, char> map = new Dictionary<char, char>();
        map.Add(']','[');
        map.Add(')','(');
        map.Add('}','{');

        Stack<char> brackets = new Stack<char>();

        for (int i = 0; i < s.Length; i++) {
            if (!map.ContainsKey(s[i])) {
                // add opening bracket to the stack
                Console.WriteLine("pushing: " + s[i]);
                brackets.Push(s[i]);

                // go to next character
                continue;
            }
            if (map.ContainsKey(s[i])) {
                // pop from the stack and confirm they are the matching pair
                if (brackets.Count() > 0) {

                char opening = brackets.Pop();
                if (map[s[i]] == opening) {
                    // this is good, continue
                    continue;
                }
                else {
                    return false;
                }


                }
                else return false;

            }
        }

        if (brackets.Count() > 0)
            return false;

        return true;

    }
}
