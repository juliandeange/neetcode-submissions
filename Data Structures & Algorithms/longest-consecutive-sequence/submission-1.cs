public class Solution {
    public int LongestConsecutive(int[] nums) {

        if (nums.Length == 0)
            return 0;
        else if (nums.Length == 1)
            return 1;

        Array.Sort(nums);
        int largest = 0;
        int current = 1;
        for(int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i - 1])
                continue;
            if (nums[i] == nums[i - 1] + 1) {
                current++;
                largest = Math.Max(largest, current);
            }
            else
                current = 1;

        }



        return Math.Max(largest, current);
            
            // if (i + 1 < nums.Length) {
            //     if (nums[i] + 1 == nums[i + 1]) {
            //         Console.WriteLine("current = " + nums[i] + " next = " + nums[i + 1]);
            //         Console.WriteLine("incrementing current from " + current + " to " + (current + 1));
            //         current = current + 1;
            //         // continue;
            //     }
            //     else {
            //         if (current > largest)
            //             largest = current;
            //         current = 1;
            //     }
            // }
            

        // }

        
    }
}
