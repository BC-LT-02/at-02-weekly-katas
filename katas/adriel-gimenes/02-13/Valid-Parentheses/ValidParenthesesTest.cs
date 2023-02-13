namespace katas.AdrielGimenes.Test;

using Xunit;

public class ValidParenthesesTest
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("(())(((a)())())", true)]
    [InlineData(")((((", false)]
    [InlineData("(", false)]
    public void Test(string input, bool expected)
    {
        Assert.Equal(expected, ValidParentheses.Parentheses(input));
    }
}
