class Solution:
    def findDuplicate(self, nums: List[int]) -> int:
        nums.sort()
        result = -1
        
        i = 0;
        while i < len(nums) - 1:
            test = nums[i]
            if test == nums[i+1]:
                result = test
                break
            i += 1
        
        return result