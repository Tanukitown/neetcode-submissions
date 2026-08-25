class Solution {
    /**
     * @param {number[]} nums
     * @return {number}
     */
    longestConsecutive(nums) {
        const numSet = new Set(nums);

        let count = 0;
        for (const num of numSet) {
            if (!numSet.has(num - 1)) {
                let thisNumber = num;
                let thisCount = 1;
                while(numSet.has(thisNumber + 1)) {
                    thisCount++;
                    thisNumber++;
                }
                count = Math.max(thisCount, count);
            }
        }
        return count;
    }
}
