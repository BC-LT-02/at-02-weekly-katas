namespace katas.JorgeChavez;

public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        int count = 0;
        foreach (char t in input)
        {
            if (t == '(')
            {
                count++;
            }
            else if (t == ')')
            {
                count--;

                if (count < 0)
                {
                    return false;
                }
            }
        }

        return count == 0;
    }
}
