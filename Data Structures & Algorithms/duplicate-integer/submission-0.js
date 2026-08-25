class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        const seen = new Set();
        seen.add(nums[0]);
        let i = 1;
        while (i < nums.length) {
            if (seen.has(nums[i])) return true;
            else {
                seen.add(nums[i]);
                i++;
            }
        }
        return false;
    }
}
