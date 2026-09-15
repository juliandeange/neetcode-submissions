public class Solution {
    public bool IsPalindrome(string s) {

        string normalized = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();
        string reversed =   Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();;

        char[] array = reversed.ToCharArray();
        Array.Reverse(array);
        reversed = new string(array);

        Console.WriteLine(normalized);
        Console.WriteLine(reversed);

        return reversed == normalized;
    }
}
