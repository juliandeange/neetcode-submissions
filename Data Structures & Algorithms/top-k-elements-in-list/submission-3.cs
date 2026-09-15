public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        Dictionary<int, int> freqs = new Dictionary<int, int>();
        List<int> result = new List<int>();

        for(int i = 0; i < nums.Length; i++) {
            if (!freqs.ContainsKey(nums[i])){
                // Console.WriteLine("Adding: " + nums[i]);
                freqs.Add(nums[i], 1);
            }
            else {
                int updating = nums[i];
                // Console.WriteLine("Updating: " + updating);
                int currentCount = freqs[updating];
                // Console.WriteLine("Current Count: " + currentCount);
                int newCount = currentCount + 1;
                // Console.WriteLine("New Count: " + newCount);
                freqs[updating] = newCount;
            }
        }

        for (int i = 0; i < k; i++) {
            int maxKey = freqs.MaxBy(kvp => kvp.Value).Key;
            result.Add(maxKey);
            freqs.Remove(maxKey);
        }
        return result.ToArray();   
    }
}
