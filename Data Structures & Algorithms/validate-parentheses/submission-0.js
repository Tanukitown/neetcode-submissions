class Solution {
    /**
     * @param {string} s
     * @return {boolean}
     */
    isValid(s) {
        const parensMap = {
            "(": ")",
            "{": "}",
            "[": "]",
        };
        const brackets = [];
        for (const char of s) {
            switch (char in parensMap) {
                case true:
                    brackets.push(parensMap[char]);
                    continue;
                case false:
                    const lastIn = brackets.pop();
                    if (char !== lastIn) return false;
                    break;
            }
        }
        return brackets.length === 0;
    }
}
