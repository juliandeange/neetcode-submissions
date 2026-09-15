public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        

        Dictionary<int, int> map = new Dictionary<int, int>();
        List<int> result = new List<int>();

        for(int i = 0; i < numbers.Length; i++) {
            int needed = target - numbers[i];
            if (needed != target)
            {if (map.ContainsKey(needed)) {
                result.Add(map[needed] + 1);
                result.Add(i + 1);
                // Console.WriteLine(map[needed]);
                // Console.WriteLine(i);
                break;
            }
            else {
                if (!map.ContainsKey(numbers[i]))
                    map.Add(numbers[i], i);
                    }
            }
        }

        return result.ToArray();


    }
}
