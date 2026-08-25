public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length == 0) return false;
        List<int> seen = new List<int> {nums[0]};
        int i = 1;
        while (i < nums.Length)
        {
            if (seen.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                seen.Add(nums[i]);
                i++;
            }
        }
        return false;
    }
}