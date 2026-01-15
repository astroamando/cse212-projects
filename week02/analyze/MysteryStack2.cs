public static class MysteryStack2 {
    private static bool IsFloat(string text) {
        return float.TryParse(text, out _);
    }

    //The function adds numbers to a stack, operators 
    //are used on the two most recent items in the stack 
    // (op1 and op2 are popped from the stack). The
    // operators act on the two most recent numbers.
    //537+* = (3+7)*5 = 50
    //62+53-/ = (6+2)/(5-3) = 4
    // invalid case 1: fewer than two numbers (nothing for the operator to act on)
    // invalid case 2: adding/subracting/multiplying by zero is useless because it
    //  either does nothing or the result is zero
    // invalid case 3: teh text includes invalid characters
    // invalid case 4: there is no final answer (should be one number)
    public static float Run(string text) {
        var stack = new Stack<float>();
        foreach (var item in text.Split(' ')) {
            if (item == "+" || item == "-" || item == "*" || item == "/") {
                if (stack.Count < 2)
                    throw new ApplicationException("Invalid Case 1!");

                var op2 = stack.Pop();
                var op1 = stack.Pop();
                float res;
                if (item == "+") {
                    res = op1 + op2;
                }
                else if (item == "-") {
                    res = op1 - op2;
                }
                else if (item == "*") {
                    res = op1 * op2;
                }
                else {
                    if (op2 == 0)
                        throw new ApplicationException("Invalid Case 2!");

                    res = op1 / op2;
                }

                stack.Push(res);
            }
            else if (IsFloat(item)) {
                stack.Push(float.Parse(item));
            }
            else if (item == "") {
            }
            else {
                throw new ApplicationException("Invalid Case 3!");
            }
        }

        if (stack.Count != 1)
            throw new ApplicationException("Invalid Case 4!");

        return stack.Pop();
    }
}