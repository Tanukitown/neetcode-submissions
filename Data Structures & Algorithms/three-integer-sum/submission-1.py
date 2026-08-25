class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        if len(nums) < 3:
            return []
        elif len(nums) == 3 and nums[0] + nums[1] + nums[2] != 0:
            return []
        elif len(nums) == 3 and nums[0] + nums[1] + nums[2] == 0:
            return [[nums[0], nums[1], nums[2]]]

        result = []
        sortedNums = sorted(nums)
        for index, num in enumerate(sortedNums):
            if num > 0:
                break
            if index > 0 and num == sortedNums[index - 1]:
                continue

            left, right = index + 1, len(sortedNums) - 1
            while left < right:
                thisResult = num + sortedNums[left] + sortedNums[right]
                if thisResult < 0:
                    left += 1
                elif thisResult > 0:
                    right -= 1
                else:
                    result.append([num, sortedNums[left], sortedNums[right]])
                    left += 1
                    right -= 1
                    while left < right and sortedNums[left] == sortedNums[left - 1]:
                        left += 1
        return result