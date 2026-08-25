class Solution:
    def evalRPN(self, tokens: List[str]) -> int:
        operators = ["+", "-", "*", "/"]
        stack = []

        for token in tokens:
            if token not in operators:
                stack.append(int(token))
            else:
                first, second = stack.pop(), stack.pop()
                stack.append(
                    first + second if token == "+"
                    else second - first if token == "-"
                    else first * second if token == "*"
                    else int(second / first)
                )
        
        return stack.pop()