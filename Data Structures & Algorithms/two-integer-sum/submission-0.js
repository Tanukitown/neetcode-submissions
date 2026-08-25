class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {
        const numbers = {};
        for (let i = 0; i < nums.length; i++) {
            const complement = target - nums[i];
            if (complement in numbers) return [numbers[complement], i];
            else numbers[nums[i]] = i;
        }
        return [];
    }
}
