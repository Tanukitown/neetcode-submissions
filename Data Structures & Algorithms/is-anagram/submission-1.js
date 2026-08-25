class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        if (s.length !== t.length) return false;

        const seen = {};
        for (const i in s) {
            const char = s[i];
            if (seen[char]) seen[char] += 1;
            else seen[char] = 1;
        }
        for (const i in t) {
            const char = t[i];
            if (!seen[char]) return false;
            seen[char]--;
            if (seen[char] === 0) delete seen[char];
        }
        return true;
    }
}
