class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    productExceptSelf(nums) {
        // const res = [];
        // for (let i = 0; i < nums.length; i++) {
        //     const others = [];
        //     for (const num of nums) {
        //         if (num !== nums[i]) others.push(num);
        //     }
        //     res.push(others.reduce((x, y) => x * y, 1));
        // }
        // return res;

        // const n = nums.length;
        // const res = new Array(n);
        // const pref = new Array(n);
        // const suff = new Array(n);

        // pref[0] = 1;
        // suff[n - 1] = 1;

        // for (let i = 1; i < n; i++) {
        //     pref[i] = nums[i - 1] * pref[i - 1];
        // }
        // for (let i = n - 2; i >= 0; i--) {
        //     suff[i] = nums[i + 1] * suff[i + 1];
        // }
        // for (let i = 0; i < n; i ++) res[i] = pref[i] * suff[i];
        // return res;

        const n = nums.length;
        const res = new Array(n).fill(1);

        let prefix = 1;
        for (let i = 0; i < n; i++) {
            res[i] = prefix;
            prefix *= nums[i];
        }

        let postfix = 1;
        for (let i = n - 1; i >= 0; i--) {
            res[i] *= postfix;
            postfix *= nums[i]
        }
        return res;
    }
}
