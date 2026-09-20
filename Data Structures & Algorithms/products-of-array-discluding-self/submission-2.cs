public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        List<int> result = new List<int>();
        int prefixProduct = 1;
        int suffixProduct = 1;

        for (int i = 0; i < nums.Length; i++) {
            
            if (i == 0) {
                result.Add(1);
                // Console.WriteLine("storing: " + nums[i] + " at index: 0");
            }
            else if (i - 1 >= 0) {
                prefixProduct = prefixProduct *= nums[i - 1];
                // Console.WriteLine("profixProduct: " + prefixProduct);
                result.Add(prefixProduct);
                // Console.WriteLine("storing: " + prefixProduct + " at index: " + i);
            }

        }

        // Console.WriteLine("---------");
        // Console.WriteLine("---------");

        for (int j = nums.Length - 1; j >= 0; j--) {

            if (j + 1 <= nums.Length - 1) {
                suffixProduct = suffixProduct *= nums[j + 1];
                // Console.WriteLine("suffixProduct: " + suffixProduct);
                // Console.WriteLine("storing: " + prefixProduct + " at index: " + i);
                // Console.WriteLine("multiplying: " + suffixProduct + " by " + nums[j + 1]);
                result[j] = result[j] * suffixProduct;
            }

        }

        return result.ToArray();

        
    }
}
