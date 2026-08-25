class Solution:
    def maxArea(self, heights: List[int]) -> int:
        result = 0

        left, right = 0, len(heights) - 1
        while left < right:
            leftHeight, rightHeight = heights[left], heights[right]
            height = min(leftHeight, rightHeight)
            width = right - left
            result = max(result, height * width)
            if leftHeight < rightHeight:
                left += 1
            else:
                right -= 1

        return result