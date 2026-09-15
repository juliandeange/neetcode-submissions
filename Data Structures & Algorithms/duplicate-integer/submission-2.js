class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {

        var map = new Set()

        for (var i = 0; i < nums.length; i++) {
            if (map.has(nums[i])) {
                return true
            }
            map.add(nums[i])
        }
        return false
    }
}
