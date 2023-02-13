namespace katas.AdrielGimenes;

public class ValidParentheses
{
    public static bool Parentheses(string input)
    {
        int count = 0;
        foreach (char item in input)
        {
            if (item.Equals('(')) count++;
            if (item.Equals(')')) count--;
            if (count < 0) return false;
        }
        return count.Equals(0);
    }
}
