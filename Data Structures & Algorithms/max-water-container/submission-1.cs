public class Solution {
    public int MaxArea(int[] heights) {

        int left = 0;
        int right = heights.Length - 1;
        int result = 0;
        while (left < right) {

            // get the width
            int width = right - left;
            // get the volume using the lowest height between 2
            int minHeight = Math.Min(heights[left], heights[right]);

            int volume = width * minHeight;
            result = Math.Max(volume, result);

            // Console.WriteLine("width: " + width + " minHeight: " + minHeight);
            
            if (heights[left] < heights[right])
                left++;
            else
                right--;

        }

        return result;
        
    }
}
