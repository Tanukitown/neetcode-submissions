public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int result = piles.Max();
        int left = 1;
        int right = piles.Max();
        while (left <= right)
        {
            int mid = (left + right) / 2;
            long thisResult = 0;
            foreach (int num in piles)
            {
                thisResult += (int)Math.Ceiling((double)num / mid);
            }
            if (thisResult <= h)
            {
                result = Math.Min(result, mid);
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return result;
    }
}
