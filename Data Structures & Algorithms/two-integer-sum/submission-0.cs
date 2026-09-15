public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> result = new List<int>();

        for(int i = 0; i < nums.Length; i++) {
            int needed = target - nums[i];
            if (map.ContainsKey(needed)) {
                result.Add(map[needed]);
                result.Add(i);
                // Console.WriteLine(map[needed]);
                // Console.WriteLine(i);
                break;
            }
            map.Add(nums[i], i);
        }

        return result.ToArray();

    }
}
