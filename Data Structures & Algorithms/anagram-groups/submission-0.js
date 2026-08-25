class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {
        // const strings = {};
        // for (let i = 0; i < strs.length; i++) {
        //     const sortedStr = strs[i].split('').sort().join('');
        //     if (!strings[sortedStr]) strings[sortedStr] = [strs[i]];
        //     else strings[sortedStr].push(strs[i]);
        // };
        // return Object.values(strings);
        const res = {};
        for (const s of strs) {
            const count = new Array(26).fill(0);

            for (const c of s) {
                count[c.charCodeAt(0) - "a".charCodeAt(0)] += 1;
            }
            if (res[count]) res[count].push(s);
            else res[count] = [s];
        }

        return Object.values(res);
    }
}
