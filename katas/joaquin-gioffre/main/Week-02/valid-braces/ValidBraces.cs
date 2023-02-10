namespace Week2;

public static class ValidBraces
{
    public static bool AreValidBraces(string braces)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char brace in braces)
        {
            if (brace == '(' || brace == '[' || brace == '{')
            {
                stack.Push(brace);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char lastBrace = stack.Pop();

                if (brace == ')' && lastBrace != '(' || brace == ']' && lastBrace != '[' || brace == '}' && lastBrace != '{')
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}