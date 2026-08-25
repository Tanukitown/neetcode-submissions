class Solution {
    /**
     * @param {string[]} strs
     * @returns {string}
     */
    encode(strs) {
        const newStrs = [];
        for (const str of strs) newStrs.push(`${str.length}#${str}`);
        return newStrs.join("");
    }

    /**
     * @param {string} str
     * @returns {string[]}
     */
    decode(str) {
        const newStrs = [];
        let i = 0;
        while (i < str.length) {
            let k = i;
            while (str[k] !== "#") {
                k++;
            }
            const length = parseInt(str.substring(i, k));
            const wordStart = k + 1;
            newStrs.push(str.substring(wordStart, length + wordStart));
            i = length + wordStart;
        }
        return newStrs;
    }
}