public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        int result = nums[0];

        while (left <= right)
        {
            if (nums[left] < nums[right])
            {
                result = Math.Min(result, nums[left]);
                break;
            }
            
            int mid = (left + right) / 2;
            result = Math.Min(result, nums[mid]);
            if (nums[mid] >= nums[left])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return result;

        // while (left <= right)
        // {
        //     int mid = (left + right) / 2;
        //     result = Math.Min(result, nums[mid]);
        //     if (nums[left] <= nums[right])
        //     {
        //         result = Math.Min(result, nums[left]);
        //         break;
        //     }
        //     if (nums[right] < nums[mid])
        //     {
        //         left = mid + 1;
        //     }
        //     else
        //     {
        //         right = mid - 1;
        //     }
        // }
        // return result;
    }
}
