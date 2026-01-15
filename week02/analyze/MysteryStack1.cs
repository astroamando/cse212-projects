public static class MysteryStack1 {
    //The order of the string is reversed because each letter is 
    // added to the stack, then the letters are removed LIFO, 
    // which reverses the order in results.//
    public static string Run(string text) {
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter);

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;
    }
}